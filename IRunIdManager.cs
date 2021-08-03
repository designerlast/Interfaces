using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces
{
    public interface IVirtualManager
    {
        string RunId { get; }
        string RootFolder { get; }
        bool IsVirtualMode { get; set; }
        void SetRunIdOrSelectDB(string id);
        void SelectDB(string id);
    }
}
