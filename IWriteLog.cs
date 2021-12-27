using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IWriteLog
    {
        void WriteLog(EventId eventId,string messType, string message);
    }
}
