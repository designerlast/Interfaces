using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Convert
{
    public interface IConvertibleTo<T>
    {
        void ConvertTo(ref T obj);
    }
}
