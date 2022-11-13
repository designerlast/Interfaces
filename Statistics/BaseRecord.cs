using IntellVega.CBB.Interfaces.Enums;
using IntellVega.CBB.Interfaces.Statistics.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Statistics
{
    public class BaseRecord
    {
        public BaseRecord()
        {
            Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        /// <summary>
        /// 工位
        /// </summary>
        [DataSourceBinding("工位")]
        public string Station { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        [DataSourceBinding("时间")]
        public string? Time { get; set; }

        /// <summary>
        /// 检测结果
        /// </summary>
        [DataSourceBinding("检测结果")]
        public DetectionResult CheckResult { get; set; }
    }

}
