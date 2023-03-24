using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class BrightnessContrast
    {
        public static UInt32 Brightness(UInt32 point, int poz, int lenght)
        {
            int R;
            int G;
            int B;
            int N = (100 / lenght) * poz; //кол-во процентов
            R = (int)(((point & 0x00FF0000) >> 16) + N * 128 / 100);
            G = (int)(((point & 0x0000FF00) >> 8) + N * 128 / 100);
            B = (int)((point & 0x000000FF) + N * 128 / 100);
            //контролируем переполнение переменных
            if (R < 0) R = 0;
            if (R > 255) R = 255;
            if (G < 0) G = 0;
            if (G > 255) G = 255;
            if (B < 0) B = 0;
            if (B > 255) B = 255;
            point = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
            return point;
        }
        //контрастность
        public static UInt32 Contrast(UInt32 point, int poz, int lenght)
        {
            int R;
            int G;
            int B;
            int N = (100 / lenght) * poz; //кол-во процентов
            if (N >= 0)
            {
                if (N == 100) N = 99;
                R = (int)((((point & 0x00FF0000) >> 16) * 100 - 128 * N) / (100 - N));
                G = (int)((((point & 0x0000FF00) >> 8) * 100 - 128 * N) / (100 - N));
                B = (int)(((point & 0x000000FF) * 100 - 128 * N) / (100 - N));
            }
            else
            {
                R = (int)((((point & 0x00FF0000) >> 16) * (100 - (-N)) + 128 * (-N)) / 100);
                G = (int)((((point & 0x0000FF00) >> 8) * (100 - (-N)) + 128 * (-N)) / 100);
                B = (int)(((point & 0x000000FF) * (100 - (-N)) + 128 * (-N)) / 100);
            }
            //контролируем переполнение переменных
            if (R < 0) R = 0;
            if (R > 255) R = 255;
            if (G < 0) G = 0;
            if (G > 255) G = 255;
            if (B < 0) B = 0;
            if (B > 255) B = 255;
            point = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
            return point;
        }
        public static Bitmap Contrast(Bitmap bitmap, int contrast, int brightness)
        {
            Image<Bgr, byte> img = bitmap.ToImage<Bgr, byte>();
            Image<Bgr, byte> img2 = img.Clone();
            for (int i = 0; i < img.Rows; i++)
            {
                for (int j = 0; j < img.Cols; j++)
                {
                    int B = (int)(contrast * 0.01 * img.Data[i, j, 0] + brightness);
                    int G = (int)(contrast * 0.01 * img.Data[i, j, 1] + brightness);
                    int R = (int)(contrast * 0.01 * img.Data[i, j, 2] + brightness);
                    if (B > 255)
                        B = 255;
                    if (G > 255)
                        G = 255;
                    if (R > 255)
                        R = 255;
                    img.Data[i, j, 0] = (byte)B;
                    img.Data[i, j, 1] = (byte)G;
                    img.Data[i, j, 2] = (byte)R;
                }
            }
            return img.ToBitmap();
        }
        //only Brightness
        public static Bitmap Brightness(Image img)
        {
            var image = new Bitmap(img);
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;
            float brightness = 1.7F;
            float[][] colorMatrixElements = {
 new float[] {brightness, 0, 0, 0, 0},
new float[] {0, brightness, 0, 0, 0},
new float[] {0, 0, brightness, 0, 0},
new float[] {0, 0, 0, 1, 0},
new float[] {0, 0, 0, 0, 1}
 };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAttributes.SetColorMatrix(
            colorMatrix,
            ColorMatrixFlag.Default,
            ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width,
            height,
            GraphicsUnit.Pixel,
            imageAttributes);
            return image;
        }
    }
}