using System.Collections.Generic;

namespace IntellVega.CBB.Interfaces.Camera
{
    public interface ICameraDeviceFactory
    {
        string Name { get; }
        IEnumerable<ICameraDevice> CreateAllDrivers();
    }
}
