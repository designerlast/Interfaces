using System;
using System.Drawing;

namespace IntellVega.CBB.Interfaces.Camera
{
    public interface ICameraDevice
    {
        /// <summary>
        /// 设备基础信息
        /// </summary>
        CameraDeviceInfo CameraDeviceInfo { get; }

        /// <summary>
        /// 回调函数获取采集图片信息
        /// </summary>
        Action<CameraVegaImage> ImageCallBackAction { get; set; }

        /// <summary>
        /// 创建设备：JAI相机没有创建功能
        /// </summary>
        void Create();

        /// <summary>
        /// 打开设备
        /// </summary>
        void Open();

        /// <summary>
        /// 关闭设备
        /// </summary>
        void Close();

        /// <summary>
        /// 销毁设备：JAI相机没有销毁设备
        /// </summary>
        void Destroy();

        /// <summary>
        /// 开启连续采集模式
        /// </summary>
        void ContinuousAcquisitionStart();

        /// <summary>
        /// 开启IO模式：所谓IO模式就是相机与PLC设备连接：通过PLC的输入输出信号来控制相机是否拍照
        /// </summary>
        void DigitalIoTriggerAcquisitionStart();

        /// <summary>
        /// 软触发采集一次图片
        /// </summary>
        void SoftwareTriggerAcquisitionOnce();

        /// <summary>
        /// 停止采集图片
        /// </summary>
        void AcquisitionStop();

        /// <summary>
        /// 取一张图
        /// </summary>
        /// <returns></returns>
        Bitmap Snap();
    }
}