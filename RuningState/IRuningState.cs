using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.RuningState
{
    public interface IRuningState
    {
        /// <summary>
        /// 通知程序运行状态
        /// </summary>
        /// <param name="stateType">状态类型</param>
        void NotifyRuningState(StateType stateType);
    }
}
