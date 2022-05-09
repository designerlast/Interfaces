using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Vision
{
    public interface ISystemParameter
    {
        /// <summary>
        /// 更新UserControl的isEnabled状态
        /// </summary>
        /// <param name="isEnabled">传入的产品名称</param>
        void UpdateIsEnabledStatus(bool isEnabled);
    }
}
