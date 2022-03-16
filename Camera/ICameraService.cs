using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Camera
{
    public interface ICameraService
    {
        IEnumerable<string> GetAllCameraNames();
        ICameraDevice GetCameraByName(string name);

    }
}
