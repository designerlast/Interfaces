using System;
using System.Collections.Generic;
using System.Text;
using IntellVega.CBB.Interfaces.Enums;

namespace IntellVega.CBB.Interfaces.Attributes
{
    public class MatchAttribute:RemarkAttribute
    {
        public MatchType MatchType { get; set; }
        public MatchAttribute(MatchType matchType, string remarkLocalName, bool isEnabled = true, string description = null) : base(
            remarkLocalName, isEnabled, description)
        {
            MatchType = matchType;
        }
    }
}
