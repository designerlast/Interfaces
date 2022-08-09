using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces
{
    public interface IRunContext
    {
        string ID { get; }
        bool ContainsKey(string key);
        void SetValue(string key, object val);
        T GetValue<T>(string key);
        int LoopIndex { get; set; }
        TriggerToken Token { get; set; }
        IRunContext NextContext { get; set; }
        bool IsEmpty { get; }
        List<object> Enumerators { get; set; }
    }
}
