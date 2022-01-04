using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Camera
{
   public class VegaFrameInfo
    {
        public VegaPixelFormat PixelFormat { get; set; }

        /// <summary>
        /// 宽度，单位像素
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 高度，单位像素
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// 每个像素占据几个bit
        /// </summary>
        public int BitPerFixel
        {
            get
            {
                switch (PixelFormat)
                {
                    case VegaPixelFormat.Mono8:
                        return 8;
                    case VegaPixelFormat.BayerGR8:
                    case VegaPixelFormat.BayerRG8:
                    case VegaPixelFormat.BayerBG8:
                    case VegaPixelFormat.BayerGB8:
                        return 24;
                    default:
                        return 24;
                }
            }
        }
        /// <summary>
        /// 实际宽度（补齐到四个字节的整数倍），单位字节数.
        /// </summary>
        public int Stride => GetStride(Width, BitPerFixel);

        public static int GetStride(int width, int bitPerPixel)
        {
            // 计算位数
            var stride = width * bitPerPixel / 8;
            // 对齐
            if (stride % 4 == 0)
            {
                return stride;
            }
            else
            {
                return stride + 4 - stride % 4;
            }
        }
    }
}
