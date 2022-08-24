using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DevicesStatus
{
    public interface IConnectionStatus
    {
        /// <summary>
        /// 更新设备连接状态
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isConnected"></param>
        void UpdateDeviceStatus(string name, bool isConnected);

    }
}
