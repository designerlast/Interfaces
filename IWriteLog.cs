using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IWriteLog
    {
        /// <summary>
        /// 写一条信息到日志控件
        /// </summary>
        /// <param name="eventId">没啥用</param>
        /// <param name="messType">debug/information/error/critical</param>
        /// <param name="message">消息消息</param>
        void WriteLog(string eventId,string messType, string message);
    }
}
