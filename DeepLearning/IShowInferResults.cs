using System.Collections.Generic;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IShowInferResults
    {
        void ShowModelData(string modelFolderPath);

        void AddModelData(object obj);

        string GetCheckedVersion();

        void SetConfusionMatrix(string version, List<string> matrixTitle, List<List<double>> matrixData);
    }
}
