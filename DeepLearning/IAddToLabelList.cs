using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IAddToLabelList
    {
        void AddToLabelList<T>(T obj);
    }
}
