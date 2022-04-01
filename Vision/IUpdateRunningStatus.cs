using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Vision
{
    public interface IUpdateRunningStatus
    {
        void UpdateProductName(string productName);
        void UpdateCuttingTime(string cuttingTime);
        void UpdateProcessStatus(string processStatus);
        void UpdateXAxis(float xAxis);
        void UpdateYAxis(float yAxis);
        void UpdateΘAxis(float θAxis);
        void UpdateZAxis(float zAxis);
    }
}
