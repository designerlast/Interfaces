using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.RuningState
{
    public class RuningState : IRuningState
    {
        public void NotifyRuningState(StateType stateType)
        {
            RuningStateChanged?.Invoke(stateType);
        }

        public event Action<StateType> RuningStateChanged;
    }
}
