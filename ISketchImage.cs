using System.Drawing;

namespace IntellVega.CBB.Interfaces
{
    public interface ISketchImage
    {
        /// <summary>
        /// 设置SketchImage顶部状态栏消息内容
        /// </summary>
        /// <param name="message"></param>
        void SetTitleMessage(object viewModel, string message);

        /// <summary>
        /// 设置控件背景图片
        /// </summary>
        /// <param name="imagePath"></param>
        void SetBackgroundImage(object viewModel, string imagePath);

        /// <summary>
        /// 设置控件背景图片
        /// </summary>
        /// <param name="bitmap"></param>
        void SetBackgroundImage(object viewModel, Bitmap bitmap);
    }
}
