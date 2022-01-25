using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IAttachableObject
    {
        object Content { get; set; }
        Type ContentType { get; }
        void AttachAllToViewModel();
        void DetachAllFromViewModel();
        void AddLink(ViewMappingLink link);
        void RemoveLink(ViewMappingLink link);
        void UpdateObject();
    }
    public interface IAttachableCollection
    {
        IEnumerable<IDelegateArg> AttachableItems { get; }
    }
    public interface IShapeContainer
    {
        // 向容器内添加一个几何元素时可能由于两种几何类型处于不同的Assembly导致类型不匹配
        // AddShape会自动生成匹配的类型并返回，调用方需替换掉改几个类型实例
        IAttachableObject AttachObject(IAttachableObject viewModel);
        void DetachObject(IAttachableObject viewModel);
        void UpdateObject(IAttachableObject viewModel);
    }
}
