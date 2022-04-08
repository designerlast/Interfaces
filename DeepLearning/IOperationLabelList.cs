namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IOperationLabelList
    {
        void SetLableSelected(string id);

        void AddToLabelList<T>(string key, T shape);

        void ImageChanged(string key);

        void DeleteToLabelList(string ShapeID);
    }
}
