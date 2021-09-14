using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IRunStatus
    {
        void RunDefault();
        public event Action<string> SetStatus;
    }
}
