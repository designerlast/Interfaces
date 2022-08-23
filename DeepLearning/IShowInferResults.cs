namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IShowInferResults
    {
        void ShowModelData(string modelFolderPath);

        void AddModelData(object obj);

        string GetCheckedVersion();
    }
}
