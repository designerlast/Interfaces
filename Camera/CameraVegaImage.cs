using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Camera
{
    public class CameraVegaImage : VegaImage
    {
        public string Name { get; set; }
        //此属性表明图片ID 理论上由1依次递增缺失的ID为对应的丢失图片
        public int Serial { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
