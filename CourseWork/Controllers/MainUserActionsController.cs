using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClosedXML.Excel;
using CourseWork.Models;

namespace CourseWork.Controllers
{

    public class MainUserActionsController : Controller
    {
        public static int yearR = 0;
        public static int monthR = 0;
        private WaterMeterContext db = new WaterMeterContext();


        public ActionResult History()
        {
            return View(db.Transmissions.Where(x => x.Email == User.Identity.Name).ToList());
        }
        public ActionResult ViewDia()
        {
            var d = db.Transmissions.Where(x => x.Email == User.Identity.Name).Join(db.WaterMeters,
                x => x.WaterMeterNumber,
                y => y.WaterMeterNumber,
                (x, y) => new { x.TransmissionDate, x.Value, y.TypeId }).Join(db.TypesWaterMeters,
                x => x.TypeId,
                y => y.TypeId,
                (x, y) => new { x.TransmissionDate, x.Value, y.NameType });

            List<TransmissionView> ds = new List<TransmissionView>();
            foreach (var item in d)
            {
                TransmissionView cd = new TransmissionView();
                cd.NameType = item.NameType;
                cd.TransmissionDate = item.TransmissionDate;
                cd.Value = item.Value;  // нейронка значения
                ds.Add(cd);
            }
            return View(ds);
        }
        public ActionResult CreateReportClients()
        {
            ViewBag.DB = db;

            var c = db.Transmissions;
            if (yearR != 0)
            {
                c.Where(x => x.TransmissionDate.Year == yearR);
            }

            if (monthR != 0)
            {
                c.Where(x => x.TransmissionDate.Month == monthR);
            }

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
                    worksheet.Cell(i + 2, 1).Value = listPl[i].PersonalAccount.ToString();
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
    }
}
