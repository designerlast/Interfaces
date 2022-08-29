using System;
using System.Collections.Generic;
using System.Text;
using IntellVega.CBB.Interfaces.Enums;

namespace IntellVega.CBB.Interfaces
{
    public interface IWriteLog
    {
        /// <summary>
        /// 写一条信息到日志控件
        /// </summary>
        /// <param name="eventId">没啥用</param>
        /// <param name="messType">debug/information/error/critical</param>
        /// <param name="message">消息</param>
        [Obsolete("该方法已过期,请优先使用LogLevel枚举为日志等级参数的重载")]
        void WriteLog(string eventId, string messType, string message);

        /// <summary>
        /// 写一条信息到日志控件
        /// </summary>
        /// <param name="eventId">没啥用</param>
        /// <param name="level">日志等级</param>
        /// <param name="message">消息</param>
        void WriteLog(string eventId, LogLevel level, string message);
    }
}
