using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Convert
{
    public interface IConvertibleFrom<T> : IConvertibleFrom
    {
        void ConvertFrom(T obj);
    }
    public interface IConvertibleFrom
    {
        ConvertAdapter Adapter { get; }
    }
}
