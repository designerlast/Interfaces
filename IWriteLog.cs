using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IWriteLog
    {
        void WriteLog(string eventId,string messType, string message);
    }
}
