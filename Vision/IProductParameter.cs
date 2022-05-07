using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Vision
{
    public interface IProductParameter
    {
        /// <summary>
        /// 更新产品名称
        /// </summary>
        /// <param name="productName">传入的产品名称</param>
        void UpdateProductName(string productName);

        /// <summary>
        /// 更新UserControl的isEnabled状态
        /// </summary>
        /// <param name="isEnabled">传入的产品名称</param>
        void UpdateIsEnabledStatus(bool isEnabled);
    }
}
