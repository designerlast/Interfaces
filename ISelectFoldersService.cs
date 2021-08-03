using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces
{
    public interface ISelectFoldersService
    {
        IEnumerable<string> Select(string rootPath);
    }
}
