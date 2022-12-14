using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IntellVega.CBB.Interfaces
{
    public interface IDelegateArgBase : IXmlLinqSerializable
    {
        string Name { get; }
        Type ParamType { get; }
        object FallbackValue { get; set; }
        bool IsVisible { get; set; }
        bool UseOptionalValue { get; set; }
        bool ExpandCollection { get; set; }
        event Action OnUpdateViewMapping;
    }

    public interface IDelegateArg : IDelegateArgBase, ICloneable
    {
        string BindingID { get; }
        string AtomID { get; set; }
        bool IsInput { get; }
        bool IsOutput { get; }
        void Set(IRunContext context, object val);
        object Get(IRunContext context);
        event Action<IRunContext> OnChanged;
    }

    public interface IDelegateConfig : IDelegateArgBase
    {
        event Action OnSettingsChanged;
    }

    public interface IDelegate : ICloneable, IDisposable, IXmlLinqSerializable
    {
        string AtomID { get; set; }
        string TypeName { get; }// Used to show what it is
        //Type Type { get; set; }
        IEnumerable<IDelegateArg> Inputs { get; }
        IEnumerable<IDelegateArg> Outputs { get; }
        IEnumerable<IDelegateConfig> Settings { get; }
        int EstimateAllocMemory(IRunContext context);
        void SetGenericType(Type t);// Set generic type
        Type GetGenericType();
        void Run(IRunContext context);// Support generic types only
        event Action OnDelegateChanged;
    }
}
