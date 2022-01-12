using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.MVAS
{
    public interface IStatistics
    {
        /// <summary>
        /// 加载统计分析
        /// </summary>
        void LoadStatisticsInfo();

        /// <summary>
        /// 清空统计分析
        /// </summary>
        void ClearStatisticsInfo();
    }
}
