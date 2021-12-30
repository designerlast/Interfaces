using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface ISketchImage
    {
        /// <summary>
        /// 设置SketchImage顶部状态栏的相机连接状态和颜色
        /// </summary>
        /// <param name="statusText"></param>
        /// <param name="statusTextHexColor"></param>
        public void SetCameraStatus(string statusText, string statusTextHexColor);
    }
}
