using System.Drawing;

namespace IntellVega.CBB.Interfaces
{
    public interface ISketchImage
    {
        /// <summary>
        /// 设置SketchImage顶部状态栏的相机连接状态和颜色
        /// </summary>
        /// <param name="statusText"></param>
        /// <param name="statusTextHexColor"></param>
        void SetCameraStatus(string statusText, string statusTextHexColor);

        /// <summary>
        /// 设置控件背景图片
        /// </summary>
        /// <param name="imagePath"></param>
        void SetBackgroundImage(string imagePath);

        /// <summary>
        /// 设置控件背景图片
        /// </summary>
        /// <param name="bitmap"></param>
        void SetBackgroundImage(Bitmap bitmap);
    }
}
