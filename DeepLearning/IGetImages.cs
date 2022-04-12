using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IGetImages
    {
        List<string> GetSelectedImagesForReasoning();

        List<string> GetSelectedImagesForTraining();
    }
}
