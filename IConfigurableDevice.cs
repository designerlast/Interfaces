using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IConfigurableDevice
    {
        event Action<bool> IsReadyChanged;
        bool IsReady { get; }
        string Name { get; }
    }
}
