using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface ILoggingService
    {
        void Debug(object message, bool toLogViewer = false);
        void DebugFormatted(string format, params object[] args);
        void DebugFormatted(string format, bool toLogViewer, params object[] args);

        void Info(object message, bool toLogViewer = false);
        void InfoFormatted(string format, params object[] args);
        void InfoFormatted(string format, bool toLogViewer, params object[] args);

        void Warn(object message, bool toLogViewer = false);
        void Warn(object message, Exception exception, bool toLogViewer = false);
        void WarnFormatted(string format, params object[] args);
        void WarnFormatted(string format, bool toLogViewer, params object[] args);

        void Error(object message, bool toLogViewer = false);
        void Error(object message, Exception exception, bool toLogViewer = false);
        void ErrorFormatted(string format, params object[] args);
        void ErrorFormatted(string format, bool toLogViewer, params object[] args);

        void Fatal(object message, bool toLogViewer = false);
        void Fatal(object message, Exception exception, bool toLogViewer = false);
        void FatalFormatted(string format, params object[] args);
        void FatalFormatted(string format, bool toLogViewer, params object[] args);

        bool IsDebugEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsWarnEnabled { get; }
        bool IsErrorEnabled { get; }
        bool IsFatalEnabled { get; }
    }
}