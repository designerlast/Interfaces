using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.InspectTubuleControl
{
    public  interface IInspectResult
    {
        void RefreshData(object outValue, ImageSourceEnum imageSource);
    }
}
