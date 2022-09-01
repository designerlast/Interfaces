using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Plc
{
    public interface ICommonCommunication
    {
        //连接状态
        bool IsOpen { get; }
        //实例名称
        string Name { get; }
        int CountNum { get; }
        Guid Guid { get; }

        bool ReadBool(string startAddress, out bool value);

        bool ReadShort(string startAddress, out short value);

        bool ReadUShort(string startAddress, out ushort value);

        bool ReadInt32(string startAddress, out int value);

        bool ReadUInt32(string startAddress, out uint value);

        bool ReadFloat(string startAddress, out float value);

        bool ReadInt64(string startAddress, out long value);

        bool ReadUInt64(string startAddress, out ulong value);

        bool ReadDouble(string startAddress, out double value);

        bool ReadBool(string startAddress, ushort length, out bool[] value);

        bool ReadShort(string startAddress, ushort length, out short[] value);

        bool ReadUShort(string startAddress, ushort length, out ushort[] value);

        bool ReadInt32(string startAddress, ushort length, out int[] value);

        bool ReadUInt32(string startAddress, ushort length, out uint[] value);

        bool ReadFloat(string startAddress, ushort length, out float[] value);

        bool ReadInt64(string startAddress, ushort length, out long[] value);

        bool ReadUInt64(string startAddress, ushort length, out ulong[] value);

        bool ReadDouble(string startAddress, ushort length, out double[] value);

        bool ReadString(string startAddress, ushort length, out string value);

        bool Write(string address, byte[] value);

        bool Write(string address, bool value);

        bool Write(string address, bool[] value);

        bool Write(string address, double value);

        bool Write(string address, double[] value);

        bool Write(string address, float value);

        bool Write(string address, float[] value);

        bool Write(string address, int value);

        bool Write(string address, int[] value);

        bool Write(string address, long value);

        bool Write(string address, long[] value);

        bool Write(string address, short value);

        bool Write(string address, short[] value);

        bool Write(string address, string value, int length, Encoding encoding);

        bool Write(string address, ushort value);

        bool Write(string address, ushort[] value);

        bool Write(string address, uint value);

        bool Write(string address, uint[] value);

        bool Write(string address, ulong value);

        bool Write(string address, ulong[] value);
    }
}
