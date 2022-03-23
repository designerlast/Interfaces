using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Vision
{
    public interface IUpdateRunningStatus
    {
        void SetProductName(string productName);
        void SetCuttingTime(string cuttingTime);
        void SetProcessStatus(string processStatus);
        void SetCurrentCoordinate(string[] coordinateArr);
    }
}
