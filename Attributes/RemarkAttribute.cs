using System;

namespace IntellVega.CBB.Interfaces
{
    /// <summary>
    /// 属性描述信息，包括字段显示名称定制化，字段的单位
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Class)]
    public class RemarkAttribute : Attribute
    {
        /// <summary>
        /// If user specify a local name, like a Chinese local name,then use attr.RemarkLocalName; else use default field name
        /// </summary>
        public string RemarkLocalName { get; set; }

        /// <summary>
        /// Indicates the filed is enabled or not
        /// </summary>
        public bool IsEnabled { get; set; }

        public RemarkAttribute(string remarkLocalName, bool isEnabled = true)
        {
            this.RemarkLocalName = remarkLocalName;
            this.IsEnabled = isEnabled;
        }
    }

}
