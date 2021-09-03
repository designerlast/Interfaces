using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    public interface IQueryMainframePad
    {
        object GetPadViewModel(string id);
        IEnumerable<string> GetPadIdList();
        public string GetViewModelId(object viewModel);
    }
}
