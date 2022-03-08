using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IAddToLabelList
    {
        string AddToLabelList<T>(T obj);
    }
}
