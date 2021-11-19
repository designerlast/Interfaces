using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IGetCurrentAndAllImages
    {
        void GetCurrentAndAllImages(Tuple<string, List<string>> tuple);
    }
}
