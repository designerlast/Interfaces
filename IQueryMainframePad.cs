using System;
using System.Collections.Generic;
using System.Text;

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
    public class ViewMappingLink
    {
        public string PadId { get; set; }
        public string ClassName { get; set; }
    }
}
