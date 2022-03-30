using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Vision
{
    public interface IUpdateRunningStatus
    {
        void SetProductName(float productName);
        void SetCuttingTime(float cuttingTime);
        void SetProcessStatus(float processStatus);
        void SetCurrentCoordinate(float[] coordinateArr);
    }
}
