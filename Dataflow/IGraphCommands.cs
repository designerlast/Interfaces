using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IGraphCommands
    {
        void OnOpenCommandExcute();
        void OnSaveCommandExcute();
        void OnRunCommandExcute();
    }
}
