using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning.ResponseModel
{
    public class DetectResponseModel
    {
        public bool IsOK { get; set; }
        public int NGNum { get; set; }
        public List<NGDetail> NGDetails { get; set; }
        public List<DefectItem> DefectItems { get; set; }
    }

    public class DefectItem
    {
        public string Name { get; set; }
        public int Id{ get; set; }
    }

    public class NGDetail
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string DefectType { get; set; }
    }
}
