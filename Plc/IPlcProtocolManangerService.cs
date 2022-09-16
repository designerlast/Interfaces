using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Plc
{
    public interface IPlcProtocolManangerService
    {
        ICommonCommunication GetPlcProtocol(string plcProtocolName);

        IEnumerable<string> GetAddedPlcProtocolName();

        void ConnectPlc();
    }
}
