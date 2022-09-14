using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Communication
{
    public interface ICommunicationService
    {
        public IEnumerable<string> GetCommunicationDevicesNames();
        public ICommunicationDevice GetCommunicationDeviceByName(string name);
        public void AddCommunicationDevice(ICommunicationDevice communicationDevice);
        public void RemoveCommunicationDevice(ICommunicationDevice communicationDevice);
        public void CreateCommunicationDevices();
    }
}
