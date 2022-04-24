using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Vision
{
    public interface IUpdateCuttingPathStatus
    {
        /// <summary>
        /// 更新切割道的状态
        /// </summary>
        /// <param name="totalCount">传入的总切割道数</param>
        /// <param name="cuttingIndex">当前正在切割的索引</param>
        void UpdateCuttingPathStatus(int totalCount, int cuttingIndex);
    }
}
