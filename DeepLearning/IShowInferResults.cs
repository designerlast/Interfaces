using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IShowInferResults
    {
        void ShowInferResults(DataTable obj);
        void ShowStatisticsInfo(int totalTime, int totalCount);
    }
}
