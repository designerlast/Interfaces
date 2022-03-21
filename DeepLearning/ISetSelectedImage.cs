using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface ISetSelectedImage
    {
        /// <summary>
        /// 设置选中图片
        /// </summary>
        /// <param name="currentImagePath">当前图片路径</param>
        /// <param name="isNext">是否下一张 true:是 false：上一张</param>
        void SetSelectedImage(string currentImagePath, bool isNext);
    }
}
