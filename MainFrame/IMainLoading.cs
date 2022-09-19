using System;

namespace IntellVega.CBB.Interfaces.MainFrame
{
    public interface IMainLoading
    {
        void SetLoadingState(bool isShow);

        event Action CloseMainLoadingAction;
    }
}