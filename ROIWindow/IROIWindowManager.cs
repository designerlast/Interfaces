using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.ROIWindow
{
    public interface IROIWindowManager
    {
        public List<object> GetShapeList();
        public bool ShowDialog();
        public bool ShowAndSetVisual(object visual);
        public void SetImageViewerVisualObject(object visualObject);
    }
}
