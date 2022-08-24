using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IntellVega.CBB.Interfaces.DeepLearning.ResponseModel
{
    public class ClassifyResponseModel
    {
        public List<CategoryItem> CategoryItem { get; set; }
    }

    public class CategoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Confidence { get; set; }
        public Rectangle Rectangle { get; set; }
    }
}
