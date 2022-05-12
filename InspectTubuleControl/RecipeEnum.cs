using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntellVega.CBB.Interfaces.InspectTubuleControl
{
    public enum RecipeEnum
    {
        [Description("侧端-左")]
        SideLeft,
        [Description("侧端-右")]
        SideRight,
        [Description("圆端-大")]
        CircleBig,
        [Description("圆端-小")]
        CircleSmall,
        [Description("黑点")]
        BlackSpot
    }
}
