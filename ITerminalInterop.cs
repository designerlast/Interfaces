using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface ITerminalInterop
    {
        bool Visible { get; set; }
        IDelegateArg BindingArg { get; set; }
    }
}
