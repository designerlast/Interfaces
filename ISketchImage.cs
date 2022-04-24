﻿using System.Drawing;

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

        /// <summary>
        /// 通过相机自定义名称切换相机，比如传入“相机1”
        /// 仅支持Image1
        /// </summary>
        /// <param name="name"></param>
        void SwitchCameraByCustomName(string name, object viewModel = null);

        /// <summary>
        /// 通过相机id切换相机
        /// 仅支持Image1
        /// </summary>
        /// <param name="id"></param>
        void SwitchCameraById(string id, object viewModel = null);

        /// <summary>
        /// 显示十字中心线
        /// </summary>
        /// <param name="showCross"></param>
        /// <param name="deltaX">像素单位</param>
        /// <param name="deltaY">像素单位</param>
        /// <param name="sideLength">侧翼长度</param>
        void ShowCross(bool showCross, int deltaX = 0, int deltaY = 0, int sideLength = 100);
    }
}
