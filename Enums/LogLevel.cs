using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Enums
{
    public enum LogLevel
    {
        /// <summary>
        /// 调试
        /// </summary>
        Debug = 1 << 0,

        /// <summary>
        /// 信息
        /// </summary>
        Information = 1 << 1,

        /// <summary>
        /// 警告
        /// </summary>
        Warning = 1 << 2,

        /// <summary>
        /// 错误
        /// </summary>
        Error = 1 << 3,

        /// <summary>
        /// 致命
        /// </summary>
        Fatal = 1 << 4
    }
}
