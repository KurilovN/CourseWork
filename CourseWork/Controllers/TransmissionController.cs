using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Data.Entity;
using System.Security.Claims;
using Microsoft.Owin.Security;
using CourseWork.Models; // пространство имен моделей
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using ClosedXML.Excel;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Drawing;
using Alturos.Yolo;
using Alturos.Yolo.Model;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Imaging;

namespace CourseWork.Controllers
{
    public class TransmissionController : Controller
    {
        WaterMeterContext db = new WaterMeterContext();

        public ActionResult Client()
        {
            return View(db.Transmissions.ToList());
        }
        public ActionResult FirstMenu()
        {
           
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Transmission([Bind(Include = "WaterMeterNumber, PersonalAccount, TransmissionDate, Comment, Value, PostedFile")] TransmissionView tr)
        {
            string path = Server.MapPath("~/Uploads/");
            HttpPostedFileBase photo = Request.Files[0];
            if (photo != null && photo.ContentLength > 0)
            {
                MemoryStream stream = new MemoryStream();
                var fileName = Path.GetFileName(photo.FileName);
                photo.SaveAs(Path.Combine(path, fileName));
                Image imge = Image.FromFile(path + fileName);
                imge.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] fileArray = stream.ToArray();
                using (var client = new HttpClient())
                //{
                //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //    using (var content = new MultipartFormDataContent())
                //    {
                //        var fileContent = new ByteArrayContent(fileArray);
                //        fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                //        {
                //            FileName = "ImageMetter.jpeg"
                //        };
                //        content.Add(fileContent);
                //        var result = client.PostAsync("https://localhost:44301/api/RegonizeMeter/GetImageMetter", content).Result;
                //        if (result.IsSuccessStatusCode)
                //        {
                //            var httpContent = result.Content.ReadAsStreamAsync();
                //            httpContent.Wait();
                //            var headers = result.Headers.GetValues("result").FirstOrDefault();
                //            var Httpstream = httpContent.Result;
                //            Image img = Image.FromStream(Httpstream);
                //        }

                //    }
                //}
                imge.Dispose();
                var TotalRes = RegonizeImageTotalResult(stream);
                Image FImage = Image.FromStream(TotalRes.ImageMeter);
                //var imStream = RegonizeImage(stream);
                //Image finalImage = Image.FromStream(imStream);
                var pokaz = TotalRes.RegonizeDigit;
                Bitmap bm = (Bitmap)FImage.Clone();
                //bm.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Bitmap bm2 = (Bitmap)bm.Clone();
                bm2.Save(Path.Combine(path, "kek.jpg"));
                var b = db.WaterMeters.Where(x => x.WaterMeterNumber == tr.WaterMeterNumber).Join(db.WaterMeters,
                              x => x.WaterMeterNumber,
                              y => y.WaterMeterNumber,
                              (x, y) => new { x.WaterMeterNumber, y.MarkId, y.TypeId, y.StartDate, tr.PersonalAccount, tr.TransmissionDate, tr.Comment, tr.Value }).Where(x => x.PersonalAccount == tr.PersonalAccount).Join(db.Clients,
                              x => x.PersonalAccount,
                              y => y.PersonalAccount,
                              (x, y) => new { x.WaterMeterNumber, x.MarkId, x.TypeId, x.StartDate, x.PersonalAccount, y.FIO, y.Adress, x.TransmissionDate, x.Comment, x.Value }).Join(db.MarkWaterMeters,
                               x => x.MarkId,
                              y => y.MarkId,
                              (x, y) => new { x.WaterMeterNumber, x.MarkId, x.TypeId, x.StartDate, x.PersonalAccount, x.FIO, x.Adress, y.NameMark, x.TransmissionDate, x.Comment, x.Value }).Join(db.TypesWaterMeters,
                               x => x.TypeId,
                              y => y.TypeId,
                              (x, y) => new { x.WaterMeterNumber, x.MarkId, x.TypeId, x.StartDate, x.PersonalAccount, x.FIO, x.Adress, x.NameMark, y.NameType, x.TransmissionDate, x.Comment, x.Value }).ToList();
                TransmissionView cd = new TransmissionView();
                foreach (var item in b)
                {
                    cd.WaterMeterNumber = item.WaterMeterNumber;
                    cd.NameMark = item.NameMark;
                    cd.NameType = item.NameType;
                    cd.StartDate = item.StartDate.AddYears(5);
                    cd.PersonalAccount = item.PersonalAccount;
                    cd.FIO = item.FIO;
                    cd.Adress = item.Adress;
                    cd.TransmissionDate = DateTime.Now;
                    cd.Value = pokaz;  // нейронка значения
                    cd.Comment = "Передача показаний"; // какой то дефолт коммент
                    cd.PostedFile = tr.PostedFile;
                }
                return View("SecondMenu", cd);
            }
            return View("SecondMenu");
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Record([Bind(Include = "WaterMeterNumber, PersonalAccount, TransmissionDate, Comment, Value")] TransmissionView tr)
        {
            Transmission tr2 = new Transmission();
            tr2.WaterMeterNumber = tr.WaterMeterNumber;
            tr2.PersonalAccount = tr.PersonalAccount;
            tr2.TransmissionDate = tr.TransmissionDate;
            tr2.Comment = tr.Comment;
            tr2.Value = tr.Value;
            tr2.Email = User.Identity.Name;
           
                try
                {
                    db.Transmissions.Add(tr2);
                    db.SaveChanges();
                    return RedirectToAction("History","MainUserActions");
                }
                catch
                {



                    return RedirectToAction("Index");
                }

            return RedirectToAction("History", "MainUserActions");//БУДЕТ отправлять на историю отправки
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateReportClients()
        {
            ViewBag.DB = db;

            var c = db.Transmissions.Where(x => x.Email == User.Identity.Name).ToList();

            List<Transmission> listPl = new List<Transmission>();

            foreach (var item in c)
            {
                Transmission p = new Transmission();
                p.PersonalAccount = item.PersonalAccount;
                p.WaterMeterNumber = item.WaterMeterNumber;
                p.TransmissionDate = item.TransmissionDate;
                p.Comment = item.Comment;
                p.Value = item.Value;
                listPl.Add(p);
            }

            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Показания");

                worksheet.Cell("A1").Value = "Лицевой счет";
                worksheet.Cell("B1").Value = "Серийный номер счетчика";
                worksheet.Cell("C1").Value = "Дата снятия показания";
                worksheet.Cell("D1").Value = "Комментарий";
                worksheet.Cell("E1").Value = "Показание";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < listPl.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = listPl[i].PersonalAccount;
                    worksheet.Cell(i + 2, 2).Value = listPl[i].WaterMeterNumber;
                    worksheet.Cell(i + 2, 3).Value = listPl[i].TransmissionDate;
                    worksheet.Cell(i + 2, 4).Value = listPl[i].Comment;
                    worksheet.Cell(i + 2, 5).Value = listPl[i].Value;

                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"История_показаний{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }
        public ActionResult CreateReport()
        {
            ViewBag.DB = db;

            var c = db.Transmissions.Where(x => x.Email == User.Identity.Name).ToList();

            List<Transmission> listPl = new List<Transmission>();

            foreach (var item in c)
            {
                Transmission p = new Transmission();
                p.PersonalAccount = item.PersonalAccount;
                p.WaterMeterNumber= item.WaterMeterNumber;
                p.TransmissionDate = item.TransmissionDate;
                p.Comment = item.Comment;
                p.Value = item.Value;
                listPl.Add(p);
            }

            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Показания");

                worksheet.Cell("A1").Value = "Лицевой счет";
                worksheet.Cell("B1").Value = "Серийный номер счетчика";
                worksheet.Cell("C1").Value = "Дата снятия показания";
                worksheet.Cell("D1").Value = "Комментарий";
                worksheet.Cell("E1").Value = "Показание";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < listPl.Count; i++)
                {
                        worksheet.Cell(i + 2, 1).Value = listPl[i].PersonalAccount;
                        worksheet.Cell(i + 2, 2).Value = listPl[i].WaterMeterNumber;
                        worksheet.Cell(i + 2, 3).Value = listPl[i].TransmissionDate;
                        worksheet.Cell(i + 2, 4).Value = listPl[i].Comment;
                        worksheet.Cell(i + 2, 5).Value = listPl[i].Value;

                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"История_показаний{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }
        private float epsilon = 18f;
        private float epsilonX = 15f;
        //чистим память
        private void clearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        //Гауссовский шум
        private Bitmap gaussianNoise(Bitmap input, int n)
        {
            Bitmap image = input;//your bitmap image
            Image<Hsv, Byte> templateImageInHsv = image.ToImage<Hsv, Byte>();
            templateImageInHsv = templateImageInHsv.SmoothGaussian(n);
            return templateImageInHsv.ToBitmap();
        }
        private bool checkInMassiv(List<byte> array, int index)
        {
            foreach (var chislo in array)
            {
                if (index == chislo)
                    return true;
            }
            return false;
        }
        private string commaBeforeFloat(string input)
        {
            if (input.Length == 8)
            {
                input = input.Substring(0, 5) + ',' + input.Substring(5, 3);
            }
            //если строка меньше длины 8 то просто в начало вставляем 0
            //
            else if (input.Length < 8)
            {
                char pattern = '0';
                int i = 0;
                string pr = "";
                while (i < (8 - input.Length))
                {
                    pr += pattern;
                    i++;
                }
                input = pr + input;
                input = input.Substring(0, 5) + ',' + input.Substring(5, 3);
            }
            //если строка больше длины 8 нужно очистить
            //
            else if (input.Length > 8)
            {
                //TODO: повысить епсилон и метод вызвать
                int start = input.Length - 8;
                input = input.Substring(start);
                input = input.Substring(0, 5) + ',' + input.Substring(5, 3);
            }
            return input;
        }
        //TODO: метод для убирания чисел рядом
        private List<YoloItem> deleteDigit(List<YoloItem> digits)
        {
            List<byte> shlack = new List<byte>();
            int i = 0;
            while (i < digits.Count)
            {
                var curDig = digits[i];
                if (checkInMassiv(shlack, i))
                {
                    i++;
                    continue;
                }
                var j = i + 1;
                while (j < digits.Count)
                {
                    var subElement = digits[j];
                    double distance = Math.Sqrt(Math.Pow((subElement.X - curDig.X), 2) + Math.Pow((subElement.Y - curDig.Y),
                   2));
                    if (distance < epsilon)
                    {
                        if (!checkInMassiv(shlack, j))
                            shlack.Add((byte)j);
                    }
                    j++;
                }
                i++;
            }
            var element = new List<YoloItem>();
            for (var inc = 0; inc < digits.Count; inc++)
            {
                if (!checkInMassiv(shlack, inc))
                {
                    element.Add(digits[inc]);
                }
            }
            return element;
        }
        public MemoryStream RegonizeImage(Stream streamImage)
        {
            MemoryStream stream = (MemoryStream)streamImage;
            var yolo = new
           YoloWrapper(@"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter.cfg",
  @"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter_last.weights",
   @"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter.names");
            List<YoloItem> items = yolo.Detect(stream.ToArray())
                .ToList<YoloItem>();
            Image finalImage = Image.FromStream(streamImage);
            Graphics graph = Graphics.FromImage(finalImage);
            Font font = new Font("Consolas", 10, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            MemoryStream resultStream = new MemoryStream();
            bool flag = false;
            Rectangle r = new Rectangle();
            foreach (var item in items)
            {
                Point rectPoint = new Point(item.X - 20, item.Y);
                Size rectSize = new Size(item.Width + item.Width/5, item.Height);
                Rectangle rect = new Rectangle(rectPoint, rectSize);
                if (!flag)
                {
                    r = rect;
                    flag = true;
                }
                Pen pen = new Pen(Color.Yellow, 5);
                graph.DrawRectangle(pen, rect);
            }
            if (flag)
            {
               
                Image matBmp = Crop(finalImage, r);
                matBmp.Save(resultStream, System.Drawing.Imaging.ImageFormat.Png);
                return resultStream;
            }
            else
            {
                //если изображения счетчика нет
                return default;
            }

        }
        public Image Crop(Image image, Rectangle selection)
        {
            Bitmap bmp = image as Bitmap;

            // Check if it is a bitmap:
            if (bmp == null)
                throw new ArgumentException("No valid bitmap");

            // Crop the image:
            Bitmap cropBmp = bmp.Clone(selection, bmp.PixelFormat);

            // Release the resources:
            image.Dispose();

            return cropBmp;
        }
        public string RegonizeImageForDigit(Stream streamImage)
        {
            string regonizeDigit = "";
            MemoryStream stream = (MemoryStream)streamImage;
            var yolo = new
           YoloWrapper(@"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter.cfg",
  @"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter_last.weights",
   @"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter.names");
            List<YoloItem> items = yolo.Detect(stream.ToArray()).ToList<YoloItem>();
            Image finalImage = Image.FromStream(streamImage);
            Graphics graph = Graphics.FromImage(finalImage);
            Font font = new Font("Consolas", 10, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            MemoryStream resultStream = new MemoryStream();
            bool flag = false;
            Rectangle r = new Rectangle();
            foreach (var item in items)
            {
                Point rectPoint = new Point(item.X - 20, item.Y);
                Size rectSize = new Size(item.Width + item.Width / 5, item.Height);
                Rectangle rect = new Rectangle(rectPoint, rectSize);
                if (!flag)
                {
                    r = rect;
                    flag = true;
                }
                Pen pen = new Pen(Color.Yellow, 5);
                graph.DrawRectangle(pen, rect);
            }
            if (flag)
            {
                //Mat matBmp = CropImage.cropColorFrame(finalImage, r);
                //matBmp.ToBitmap().Save(resultStream, ImageFormat.Png);
                // return resultStream;
            }
            else
            {
                //если изображения счетчика нет
                return default;
            }
            //сборка мусора, освободить по максимуму ресурсы
            #region clear memory
            items = null;
            graph = null;
            stream = null;
            yolo = null;
            //long totalMemoryBefore = GC.GetTotalMemory(false);
            clearMemory();
            //long totalMemoryAfter = GC.GetTotalMemory(false);
            #endregion
            Image image = Image.FromStream(resultStream);
            // Распознавание цифр
            Bitmap resize = new Bitmap(image, new Size(500, 200));
            //убираем шум брать не четное
            //resize = gaussianNoise(resize, 1);
            //ПАРАМЕТРЫ: BITMAP////КОНТРАСТНОСТЬ В ПРОЦЕНТАХ///ЯРКОСТЬ В ПРОЦЕНТАХ
            //ИЗМЕНИТЬ
            image = BrightnessContrast.Contrast(resize, 80, 0);
            var regonizeDigitYolo = new
           YoloWrapper(@"D:\Users\MGaming\Desktop\Счетчики\WebApplication1\WebApplication1\files\digits\yolov3_custom_Di
g.cfg",

           @"D:\Users\MGaming\Desktop\Счетчики\WebApplication1\WebApplication1\files\digits\yolov3_custom_60000_Dig.weigh
ts",
            @"D:\Users\MGaming\Desktop\Счетчики\WebApplication1\WebApplication1\files\digits\classes_Dig.names");
            stream = new System.IO.MemoryStream();
            image.Save(stream, ImageFormat.Png);
            stream.Position = 0;
            items = regonizeDigitYolo.Detect(stream.ToArray()).ToList<YoloItem>();
            finalImage = image;
            graph = Graphics.FromImage(finalImage);
            font = new Font("Consolas", 14, FontStyle.Bold);
            brush = new SolidBrush(Color.Red);
            //сортировка
            var col = items.OrderBy(x => x.X);
            foreach (var item in col)
            {
                Point rectPoint = new Point(item.X, item.Y);
                Size rectSize = new Size(item.Width + 4 * item.Width / 5, item.Height);
                Rectangle rect = new Rectangle(rectPoint, rectSize);
                Pen pen = new Pen(Color.Red, 4);
                graph.DrawRectangle(pen, rect);
                graph.DrawString(item.Type, font, brush, rectPoint);
                regonizeDigit += item.Type;
            }
            //чистим память
            clearMemory();
            return commaBeforeFloat(regonizeDigit);
        }


        //фото+цифры
        public TotalRegonize RegonizeImageTotalResult(Stream streamImage)
        {
            string regonizeDigit = "";
            MemoryStream stream = (MemoryStream)streamImage;
            var yolo = new
            YoloWrapper(@"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter.cfg",
   @"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter_last.weights",
    @"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\water_meter.names");
            List<YoloItem> items = yolo.Detect(stream.ToArray()).ToList<YoloItem>();
            Image finalImage = Image.FromStream(streamImage);
            Graphics graph = Graphics.FromImage(finalImage);
            Font font = new Font("Consolas", 10, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Yellow);
            MemoryStream resultStream = new MemoryStream();
            bool flag = false;
            Rectangle r = new Rectangle();
            foreach (var item in items)
            {
                Point rectPoint = new Point(item.X - 15, item.Y);
                Size rectSize = new Size(item.Width + item.Width / 5, item.Height);
                Rectangle rect = new Rectangle(rectPoint, rectSize);
                if (!flag)
                {
                    r = rect;
                    flag = true;
                }
                Pen pen = new Pen(Color.Yellow, 5);
                graph.DrawRectangle(pen, rect);
            }
            if (flag)
            {
                Image matBmp = Crop(finalImage, r);
                matBmp.Save(resultStream, System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                //если изображения счетчика нет
                return default;
            }
            //сборка мусора, освободить по максимуму ресурсы
            #region clear memory
            items = null;
            graph = null;
            stream = null;
            yolo = null;
            //long totalMemoryBefore = GC.GetTotalMemory(false);
            clearMemory();
            //long totalMemoryAfter = GC.GetTotalMemory(false);
            #endregion
            Image image = Image.FromStream(resultStream);
            // Распознавание цифр
            Bitmap resize = new Bitmap(image, new Size(500, 200));

            //убираем шум брать не четное
            resize = gaussianNoise(resize, 1);
            //ПАРАМЕТРЫ: BITMAP////КОНТРАСТНОСТЬ В ПРОЦЕНТАХ///ЯРКОСТЬ В ПРОЦЕНТАХ
            //ИЗМЕНИТЬ
            image = BrightnessContrast.Contrast(resize, 80, 0);
            var regonizeDigitYolo = new
            YoloWrapper(@"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\digit.cfg",
   @"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\digit_last.weights",
    @"C:\Users\nkuri\source\repos\WindowsFormsApp5\WindowsFormsApp5\digit.names");
            stream = new System.IO.MemoryStream();
            image.Save(stream, ImageFormat.Png);
            stream.Position = 0;
            items = regonizeDigitYolo.Detect(stream.ToArray()).ToList<YoloItem>();
            finalImage = image;
            graph = Graphics.FromImage(finalImage);
            font = new Font("Consolas", 14, FontStyle.Bold);
            brush = new SolidBrush(Color.Red);

            //сортировка
            var col = items.OrderBy(x => x.X).ToList<YoloItem>();
            col = deleteDigit(col);

            foreach (var item in col)
            {
                Point rectPoint = new Point(item.X, item.Y);
                Size rectSize = new Size(item.Width + 4 * item.Width / 5, item.Height);
                Rectangle rect = new Rectangle(rectPoint, rectSize);
                Pen pen = new Pen(Color.Red, 4);
                graph.DrawRectangle(pen, rect);
                graph.DrawString(item.Type, font, brush, rectPoint);
                regonizeDigit += item.Type;
            }
            //запятая
            regonizeDigit = commaBeforeFloat(regonizeDigit);
           
            image = finalImage; //resize;
                                //чистим память
            clearMemory();
            resultStream = new System.IO.MemoryStream();
            resultStream.Position = 0;
            image.Save(resultStream, ImageFormat.Png);
            TotalRegonize totalRegonize = new TotalRegonize()
            {
                RegonizeDigit = regonizeDigit,
                ImageMeter = resultStream
            };
            return totalRegonize;
        }
    }
}