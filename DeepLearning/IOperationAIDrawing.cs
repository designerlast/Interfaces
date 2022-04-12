namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IOperationAIDrawing
    {
        void SetShapeSelected(string shapeID);

        void DeleteDrawingShape(string shapeID);

        void SetShapeColorChanged(object obj);
    }
}
