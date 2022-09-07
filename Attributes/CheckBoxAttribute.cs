using System;

namespace IntellVega.CBB.Interfaces.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckBoxAttribute : RemarkAttribute
    {
        public CheckBoxAttribute(string remarkLocalName, bool isEnabled = true)
            : base(remarkLocalName, isEnabled)
        {
            this.RemarkLocalName = remarkLocalName;
            this.IsEnabled = isEnabled;
        }
    }
}