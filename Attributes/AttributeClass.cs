using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces
{
    public class ParameterConfig:Attribute
    {
        public bool NeedUpdate { get; set; }
        public ParameterConfig() { }
    }
}
