using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IGraphCommands
    {
        void OnNewCommandExcute();
        void OnOpenCommandExcute();
        void OnSaveCommandExcute();
        void OnRunCommandExcute();
    }
}
