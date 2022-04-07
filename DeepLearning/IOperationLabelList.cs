namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IOperationLabelList
    {
        void SetLableSelected(string id);

        void AddToLabelList<T>(T shape);

        void DeleteToLabelList(string ShapeID);
    }
}
