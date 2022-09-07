using System;

namespace IntellVega.CBB.Interfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SliderAttribute : RemarkAttribute
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
        /// 
        /// </summary>
        public int TickFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSnapToTickEnabled { get; set; }

        public SliderAttribute(string remarkLocalName, bool isEnabled = true, int min = 0, int max = 100, int tickFrequency = 1, bool isSnapToTickEnabled = true)
            : base(remarkLocalName, isEnabled)
        {
            this.RemarkLocalName = remarkLocalName;
            this.IsEnabled = isEnabled;
            this.Min = min;
            this.Max = max;
            this.TickFrequency = tickFrequency;
            this.IsSnapToTickEnabled = isSnapToTickEnabled;
        }
    }
}