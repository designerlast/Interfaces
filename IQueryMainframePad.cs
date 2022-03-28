using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace IntellVega.CBB.Interfaces
{
    public interface IQueryMainframePad
    {
        IEnumerable<string> GetPadIdList();
        public ViewMappingLink GetMappingLink(object viewModelName);
        object GetViewModel(ViewMappingLink link);
        object GetViewModel(string id);
        event Action<object> OnFocusChanged;
    }
    public class ViewMappingLink : IXmlLinqSerializable
    {
        public string PadId { get; set; }
        public string ClassName { get; set; }

        public void FromXml(XElement xml)
        {
            PadId = xml.Attribute(nameof(PadId)).Value;
            ClassName = xml.Attribute(nameof(ClassName)).Value;
        }

        public XElement ToXml(string name)
        {
            return new XElement(name,
                new XAttribute(nameof(PadId), PadId),
                new XAttribute(nameof(ClassName), ClassName)
                );
        }
    }
}
