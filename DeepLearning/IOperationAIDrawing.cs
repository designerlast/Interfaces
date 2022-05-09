namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IOperationAIDrawing
    {
        void EditImage(string imgPath, bool inCollection);

        void ClearImage();

        void SetShapeSelected(string shapeID);

        void DeleteDrawingShape(string shapeID);

        void SetShapeColorChanged(object obj);

        void SetSingleShapeChanged(string labelGuid, string labelName, string labelColo);
    }
}
