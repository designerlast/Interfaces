using System;

namespace IntellVega.CBB.Interfaces.Attributes
{
    /// <summary>
    /// 带缩放倍数的属性，小数点位数也可以指定。
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ScalableAttribute : RemarkAttribute
    {
        /// <summary>
        /// 显示单位
        /// </summary>
        public string RemarkUnit { get; set; }

        /// <summary>
        /// 缩放倍数
        /// </summary>
        public double Scale { get; set; }

        /// <summary>
        /// 显示精度
        /// </summary>
        public int Precision { get; set; }

        public ScalableAttribute(string remarkLocalName, bool isEnabled = true, string remarkUnit = "", double scale = 1.0, int precision = 0)
            : base(remarkLocalName, isEnabled)
        {
            this.RemarkLocalName = remarkLocalName;
            this.IsEnabled = isEnabled;
            this.RemarkUnit = remarkUnit;
            this.Scale = scale;
            this.Precision = precision;
        }
    }
}