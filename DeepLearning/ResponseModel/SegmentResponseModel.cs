using System;
using System.Collections.Generic;

namespace IntellVega.CBB.Interfaces.DeepLearning.ResponseModel
{
    public class SegmentResponseModel
    {
        public bool IsOK { get; set; }
        public int NGNum { get; set; }
        public List<NGDetail> NGDetails { get; set; }
        public List<DefectItem> DefectItems { get; set; }
    }
}
