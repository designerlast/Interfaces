using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IAttachableShape
    {
        void ConnectViewMapping();
        void DisconnectViewMapping();
        void AddLink(ViewMappingLink link);
        void RemoveLink(ViewMappingLink link);
    }
    public interface IAttachableCollection
    {
        IEnumerable<IAttachableShape> AttachableItems { get; }
    }
    public interface IShapeContainer
    {
        void AddShape(object viewModel);
        void RemoveShape(object viewModel);
    }
}
