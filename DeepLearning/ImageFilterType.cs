using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    /// <summary>
    /// 指定图形的类型，用于返回特定图像集合
    /// </summary>
    public enum ImageFilterType
    {
        /// <summary>
        /// 训练图集
        /// </summary>
        [Description("训练数据集")]
        Train,

        /// <summary>
        /// 推理集合
        /// </summary>
        [Description("推理数据集")]
        Reason,

        /// <summary>
        /// 验证集合
        /// </summary>
        [Description("验证数据集")]
        Validate,

        /// <summary>
        /// 标注图形
        /// </summary>
        [Description("标注数据集")]
        Labeled,

        /// <summary>
        /// 未标注图形
        /// </summary>
        [Description("未标注数据集")]
        UnLabeled
    }
}
