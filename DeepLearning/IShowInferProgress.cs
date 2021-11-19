using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IShowInferProgress
    {
        void ShowInferProgress(int processed, int total);
    }
}
