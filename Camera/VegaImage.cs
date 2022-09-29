using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces.Camera
{
    public class VegaImage
    {
        private IntPtr _intPtr;

        public VegaFrameInfo FrameInfo { get; set; }

        public byte[] OriginalDataArray { get; set; }

        public void Init(int width, int height, VegaPixelFormat pixelFormat, byte[] originalDataArray)
        {
            FrameInfo = new VegaFrameInfo() { Height = height, Width = width, PixelFormat = pixelFormat };
            OriginalDataArray = originalDataArray;
        }

        public void Init(int width, int height, VegaPixelFormat pixelFormat, IntPtr data)
        {
            _intPtr = data;
            FrameInfo = new VegaFrameInfo() { Height = height, Width = width, PixelFormat = pixelFormat };
            var dataSize = width * height * FrameInfo.BitPerFixel / 8;
            byte[] dataArray = new byte[dataSize];
            Marshal.Copy(data, dataArray, 0, dataSize);
            OriginalDataArray = dataArray;
        }

        public void Load(Image image)
        {
            Bitmap bitmap = image as Bitmap;
            var bit = Image.GetPixelFormatSize(bitmap.PixelFormat);
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            FrameInfo = new VegaFrameInfo()
            {
                Width = bitmap.Width,
                Height = bitmap.Height,
                PixelFormat = GetVegaPixelFormat(bit)
            };
            IntPtr ptr = bitmapData.Scan0;
            int scanBytes = bitmapData.Stride * bitmapData.Height;
            byte[] values = new byte[scanBytes];
            Marshal.Copy(ptr, values, 0, scanBytes);
            bitmap.UnlockBits(bitmapData);
            OriginalDataArray = values;
            bitmap.Dispose();
        }

        public void Save(string imagePath, string fileName, ImageFormat imageFormat)
        {
            Task.Run(() =>
            {
                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }
                var bitmap = ConvertToBitmap();
                bitmap.Save(imagePath + fileName, imageFormat);
                bitmap.Dispose();
            });
        }

        private VegaPixelFormat GetVegaPixelFormat(int bit)
        {
            switch (bit)
            {
                case 8:
                    return VegaPixelFormat.Mono8;
                case 24:
                    return VegaPixelFormat.BayerRG8;
                default:
                    return VegaPixelFormat.Mono8;
            }
        }

        public Bitmap ConvertToBitmap()
        {
            PixelFormat pixel = FrameInfo.BitPerFixel == 8 ? PixelFormat.Format8bppIndexed : PixelFormat.Format24bppRgb;
            Bitmap bitmap = new Bitmap(FrameInfo.Width, FrameInfo.Height, pixel);
            if (FrameInfo.BitPerFixel == 8)
            {
                ColorPalette cp = bitmap.Palette;
                for (int i = 0; i < 256; i++)
                {
                    cp.Entries[i] = Color.FromArgb(i, i, i);
                }
                bitmap.Palette = cp;
            }
            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, FrameInfo.Width, FrameInfo.Height),
                ImageLockMode.WriteOnly, pixel);
            IntPtr ptr = bmpData.Scan0;
            int scanBytes = bmpData.Stride * bmpData.Height;
            Marshal.Copy(OriginalDataArray, 0, ptr, scanBytes);
            bitmap.UnlockBits(bmpData);
            return bitmap;
        }
    }
}
