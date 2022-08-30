using System;
using System.Collections.Generic;
using System.Text;

namespace CameraLightSetting.Interfaces
{
    public interface ILightingSettingProviderFactory
    {
        /// <summary>
        /// 设置通道光源亮度
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        string SetLightIntensity(string channel, string value);

        /// <summary>
        /// 获取当前通道光源亮度
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        string GetLightIntensity(string channel);

        /// <summary>
        /// 获取当前通道的状态
        /// </summary>
        /// <returns></returns>
        string ChannelState();

        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="dataBits"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        bool Connect(string portName, int dataBits, out string error);

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        bool Disconnect(out string error);

        /// <summary>
        /// 关闭通道
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        string CloseChannel(string channel);

        /// <summary>
        /// 打开通道
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        string OpenChannel(string channel);

        /// <summary>
        /// 波特率是否正确
        /// </summary>
        /// <returns></returns>
        bool IsCorrectBaudRate();
    }
}
