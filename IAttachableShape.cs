using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IAttachableShape
    {
        IAttachableShape AttachAllToViewModel();
        void DetachAllFromViewModel();
        void AddLink(ViewMappingLink link);
        void RemoveLink(ViewMappingLink link);
    }
    public interface IAttachableCollection
    {
        IEnumerable<IAttachableShape> AttachableItems { get; }
    }
    public interface IShapeContainer
    {
        // 向容器内添加一个几何元素时可能由于两种几何类型处于不同的Assembly导致类型不匹配
        // AddShape会自动生成匹配的类型并返回，调用方需替换掉改几个类型实例
        IAttachableShape AttachShape(IAttachableShape viewModel);
        void DetachShape(IAttachableShape viewModel);
    }
}
