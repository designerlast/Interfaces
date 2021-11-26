using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Convert
{
    public interface IConvertibleFrom<T>
    {
        void ConvertFrom(T obj);
    }
}
