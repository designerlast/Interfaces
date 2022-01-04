using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface INodeInterop
    {
        object Terminals { get; }
        IDelegate InnerDelegate { get; }
    }
}
