using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellVega.InterfacesLib
{
    public interface ISelectFoldersService
    {
        IEnumerable<string> Select(string rootPath);
    }
}
