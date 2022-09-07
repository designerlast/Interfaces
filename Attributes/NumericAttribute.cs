using System;

namespace IntellVega.CBB.Interfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NumericAttribute : RemarkAttribute
    {
        /// <summary>
        /// 最小值
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        public int Max { get; set; }

        /// <summary>
        /// 增量
        /// </summary>
        public int Increment { get; set; }

        public NumericAttribute(string remarkLocalName, bool isEnabled = true, int min = 0, int max = 100, int increment = 1)
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