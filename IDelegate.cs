using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IntellVega.CBB.Interfaces
{
    public interface IDelegateArgBase
    {
        string Name { get; }
        Type ParamType { get; }
        object FallbackValue { get; set; }
    }

    public interface IDelegateArg : IDelegateArgBase, ICloneable
    {
        new Type ParamType { get; set; }
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

    public interface IDelegate : ICloneable
    {
        string AtomID { get; set; }
        string TypeName { get; }
        //Type Type { get; set; }
        IEnumerable<IDelegateArg> Inputs { get; }
        IEnumerable<IDelegateArg> Outputs { get; }
        IEnumerable<IDelegateConfig> Settings { get; }
        int EstimateAllocMemory(IRunContext context);
        void SetType(Type t);// Set generic type
        Type GetActivityType(); void Run(IRunContext context);// Support generic types only
        XElement ToXml(string name);
        void FromXml(XElement element);
        event Action OnDelegateChanged;
    }
}
