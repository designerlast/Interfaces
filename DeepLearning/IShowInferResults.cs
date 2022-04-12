namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IShowInferResults
    {
        void ShowStatisticsInfo(int totalTime, int totalCount, double ar, double ap, double miou);
    }
}
