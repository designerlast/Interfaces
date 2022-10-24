using System;

namespace IntellVega.CBB.Interfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NumericAttribute : RemarkAttribute
    {
        /// <summary>
        /// 最小值
        /// </summary>
        public double Min { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        public double Max { get; set; }

        /// <summary>
        /// 增量
        /// </summary>
        public double Increment { get; set; }


        public NumericAttribute(string remarkLocalName, bool isEnabled = true, double min = 0d, double max = 100d, double increment = 1d)
            : base(remarkLocalName, isEnabled)
        {
            this.RemarkLocalName = remarkLocalName;
            this.IsEnabled = isEnabled;
            this.Min = min;
            this.Max = max;
            this.Increment = increment;
        }
    }
}