using System;
using System.Collections.Generic;
using System.Text;
using IntellVega.CBB.Interfaces.Enums;

namespace IntellVega.CBB.Interfaces.ROIWindow
{
    public interface ITemplateMatchingWindowManager
    {
        public bool ShowDialog(MatchType matchType);
        public bool ShowAndSetData(MatchType matchType, string modelPath);
        public string GetResult(MatchType matchType);
        public object GetNCCModel(string modelPath);
    }
}
