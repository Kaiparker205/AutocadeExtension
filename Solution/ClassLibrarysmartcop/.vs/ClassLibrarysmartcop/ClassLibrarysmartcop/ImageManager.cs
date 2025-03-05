using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;


namespace ClassLibrarysmartcop
{
    class ImageManager
    {
        /// <summary>
        /// Creates a resizable image with a custom drawn icon.
        /// </summary>
        /// <param name="width">Desired image width.</param>
        /// <param name="height">Desired image height.</param>
        /// <returns>A BitmapSource that can be assigned to RibbonButton.Image properties.</returns>
        public static BitmapSource CreateResizableImage(int width, int height)
        {
            using (Bitmap bitmap = new Bitmap(width, height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Set high quality rendering options.
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    // Optional: fill background with a light gray color.
                    g.FillRectangle(new SolidBrush(Color.FromArgb(240, 240, 240)), 0, 0, width, height);

                    // Draw a border.
                    g.DrawRectangle(new Pen(Color.FromArgb(0, 120, 212), 1), 0, 0, width - 1, height - 1);

                    // Draw a simple document icon.
                    int margin = width / 6;
                    // Draw document outline.
                    g.FillRectangle(new SolidBrush(Color.White),
                        margin, margin, width - 2 * margin, height - 2 * margin);
                    g.DrawRectangle(new Pen(Color.FromArgb(0, 120, 212), 1),
                        margin, margin, width - 2 * margin, height - 2 * margin);

                    // Draw document fold.
                    Point[] fold = new Point[]
                    {
                    new Point(width - margin, margin),
                    new Point(width - margin, margin + (height - 2 * margin) / 3),
                    new Point(width - margin - (width - 2 * margin) / 3, margin)
                    };
                    g.FillPolygon(new SolidBrush(Color.FromArgb(230, 230, 230)), fold);
                    g.DrawPolygon(new Pen(Color.FromArgb(0, 120, 212), 1), fold);

                    // Draw some lines to represent text.
                    int lineY = height / 2;
                    g.DrawLine(new Pen(Color.FromArgb(150, 150, 150), 1),
                        margin + 2, lineY, width - margin - 2, lineY);
                    g.DrawLine(new Pen(Color.FromArgb(150, 150, 150), 1),
                        margin + 2, lineY + height / 6, width - margin - 2, lineY + height / 6);
                }

                // Convert System.Drawing.Bitmap to BitmapSource.
                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Png);
                    stream.Position = 0;

                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = stream;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();

                    return bitmapImage;
                }
            }
        }

        /// <summary>
        /// Loads an image from a file and resizes it to the specified dimensions.
        /// </summary>
        /// <param name="imagePath">The full file path of the image.</param>
        /// <param name="width">Desired width.</param>
        /// <param name="height">Desired height.</param>
        /// <returns>A BitmapSource that can be assigned to RibbonButton.Image properties.</returns>
        public static BitmapSource LoadAndResizeImage(string imagePath, int width, int height)
        {
            using (Bitmap originalBitmap = new Bitmap(imagePath))
            {
                using (Bitmap resizedBitmap = new Bitmap(width, height))
                {
                    using (Graphics g = Graphics.FromImage(resizedBitmap))
                    {
                        // Set high quality rendering options.
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(originalBitmap, 0, 0, width, height);
                    }

                    // Convert the resized bitmap to BitmapSource.
                    using (MemoryStream stream = new MemoryStream())
                    {
                        resizedBitmap.Save(stream, ImageFormat.Png);
                        stream.Position = 0;

                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.StreamSource = stream;
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.EndInit();

                        return bitmapImage;
                    }
                }
            }
        }
    }
}