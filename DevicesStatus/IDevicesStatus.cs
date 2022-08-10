using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DevicesStatus
{
    public interface IDevicesStatus
    {
        /// <summary>
        /// 添加设备
        /// </summary>
        /// <param name="deviceName"></param>
        void AddDevice(string deviceName);
        /// <summary>
        /// 移除设备
        /// </summary>
        /// <param name="deviceName"></param>
        void RemoveDevice(string deviceName);
        /// <summary>
        /// 更新设备状态
        /// </summary>
        /// <param name="deviceName"></param>
        /// <param name="isConnected"></param>
        void UpdateDeviceStatus(string deviceName, bool isConnected);
        /// <summary>
        /// 清除设备状态列表
        /// </summary>
        void Clear();

    }
}
