using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Camera
{
    /// <summary>
    /// 像素格式枚举，目前照抄海康的作为标准。
    /// </summary>
    public enum VegaPixelFormat
    {
        Mono8 = 17301505,
        Mono10 = 17825795,
        Mono10Packed = 17563652,
        Mono12 = 17825797,
        Mono12Packed = 17563654,
        Mono16 = 17825799,
        RGB8Packed = 35127316,// 0x02180014
        YUV422_8 = 34603058,
        YUV422_8_UYVY = 34603039,
        BayerGR8 = 17301512,
        BayerRG8 = 17301513,
        BayerGB8 = 17301514,
        BayerBG8 = 1217301515,
        BayerGB10 = 17825806,
        BayerGB12 = 17825810,
        BayerGB12Packed = 17563692
    }
}
