using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.ROIWindow
{
    public interface IROIWindowManager
    {
        public event EventHandler<List<object>> WindowClosed; 
        public void Show();
        public void ShowDialog();
        public void Close();
    }
}
