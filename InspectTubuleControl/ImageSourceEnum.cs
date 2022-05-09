using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntellVega.CBB.Interfaces.InspectTubuleControl
{
    public enum ImageSourceEnum
    {
        [Description("侧端")]
        MeasureAndTip,
        [Description("圆端")]
        CircleRAndBurr,
        [Description("黑点")]
        BlackSpot
    }
}
