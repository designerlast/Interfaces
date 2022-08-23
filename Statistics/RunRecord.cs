using IntellVega.CBB.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Statistics
{
    public class RunRecord
    {
        /// <summary>
        /// 工位
        /// </summary>
        public string Station { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// 检测结果
        /// </summary>
        public DetectionResult CheckResult { get; set; }

        /// <summary>
        /// 输出结果
        /// </summary>
        public string OutputResult { get; set; }

        /// <summary>
        /// 配方
        /// </summary>
        public string Recipe { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
    }

}
