using System;
using System.Collections.Generic;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IOperationImageList
    {
        /// <summary>
        /// 设置选中图片
        /// </summary>
        /// <param name="imagePath">当前图片路径</param>
        /// <param name="isNext">是否下一张 true:是 false：上一张</param>
        void SetSelectedImage(string imagePath, bool isNext);

        /// <summary>
        /// 设置图片标注状态
        /// </summary>
        /// <param name="imagePath">图片路径</param>
        /// <param name="isMarked">True: 已标注 False: 未标注</param>
        void SetImageMarkState(string imagePath,bool isMarked);

        /// <summary>
        /// 获取推理图片集
        /// </summary>
        /// <returns></returns>
        List<string> GetImagesForReasoning();

        /// <summary>
        /// 获取训练图片集
        /// </summary>
        /// <returns></returns>
        List<string> GetImagesForTraining();

        /// <summary>
        /// 更新图片推理结果
        /// </summary>
        /// <param name="imagePath"></param>
        /// <param name="result"></param>
        void UpdateImageReasonResult(string imagePath, List<Tuple<string, double>> result);
    }
}
