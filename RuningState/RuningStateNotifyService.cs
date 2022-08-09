using System;

namespace IntellVega.CBB.Interfaces.RuningState
{
    public class RuningStateNotifyService 
    {
        public event Action<StateType> RuningStateChanged;

        public void Notify(StateType stateType)
        {
            RuningStateChanged?.Invoke(stateType);
        }
    }
}
