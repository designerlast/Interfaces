using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Statistics.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CameraDataBaseModelAttribute : Attribute
    {
        public string CameraName { get; set; }
        public Type Type { get; set; }

        public CameraDataBaseModelAttribute(string cameraName, Type type)
        {
            CameraName = cameraName;
            Type = type;
        }
    }
}
