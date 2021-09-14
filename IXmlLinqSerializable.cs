using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace IntellVega.CBB.Interfaces
{
    public interface IXmlLinqSerializable
    {
        public XElement ToXml();
        public void FromXml(XElement xml);
    }
}
