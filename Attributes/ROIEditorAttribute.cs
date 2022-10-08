using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Attributes
{
    public class ROIEditorAttribute:RemarkAttribute
    {
        public ROIEditorAttribute(string remarkLocalName, bool isEnabled = true, string description = null) : base(remarkLocalName, isEnabled, description)
        {
        }
    }
}
