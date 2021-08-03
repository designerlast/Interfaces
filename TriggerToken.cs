using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces
{
    public class TriggerToken
    {
        public List<int> Indices { get; private set; } = new List<int>();
        public TriggerToken ParentToken { get; private set; }
        public override string ToString()
        {
            return string.Format("<{0}>", string.Join(", ", Indices));
        }
    }
}
