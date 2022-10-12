using System;
using System.Collections.Generic;
using System.Text;
using IntellVega.CBB.Interfaces.Enums;

namespace IntellVega.CBB.Interfaces.ROIWindow
{
    public interface ITemplateMatchingWindowManager
    {
        public bool ShowDialog(MatchType matchType);

        /// <summary>
        /// 获取模型
        /// </summary>
        /// <returns></returns>
        public object GetModel(MatchType matchType);
    }
}
