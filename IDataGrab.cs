using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces
{
    public interface IDataGrabber<T,TID>
    {
        void Add(ref object settingData, TID ID = default(TID));
        void Save(string filename);
        void Load(string filename);
    }
}
