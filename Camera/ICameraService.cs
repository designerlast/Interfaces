using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Camera
{
    public interface ICameraService
    {
        /// <summary>
        /// 获取相机的友好名字
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetAllCameraNames();

        /// <summary>
        /// 通过友好名字获取相机
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ICameraDevice GetCameraByName(string name);

        /// <summary>
        /// 获取已连接相机的Id
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetConnectedCameraIds();

        /// <summary>
        /// 通过Id获取相机
        /// </summary>
        /// <param name="cameraId"></param>
        /// <returns></returns>
        ICameraDevice GetCameraById(string cameraId);
    }
}
