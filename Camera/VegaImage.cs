using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Camera
{
    public class VegaImage
    {
        public VegaFrameInfo FrameInfo { get; set; }
        public byte[] OriginalDataArray { get; set; }
    }
}
