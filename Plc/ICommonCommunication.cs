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
        //流水号
        int CountNum { get; }
        Guid Guid { get; }

        void Read(string startAddress, ushort length, out byte[] value);

        void ReadBool(string startAddress, out bool value);

        void ReadShort(string startAddress, out short value);

        void ReadUShort(string startAddress, out ushort value);

        void ReadInt32(string startAddress, out int value);

        void ReadUInt32(string startAddress, out uint value);

        void ReadFloat(string startAddress, out float value);

        void ReadInt64(string startAddress, out long value);

        void ReadUInt64(string startAddress, out ulong value);

        void ReadDouble(string startAddress, out double value);

        void ReadBool(string startAddress, ushort length, out bool[] value);

        void ReadShort(string startAddress, ushort length, out short[] value);

        void ReadUShort(string startAddress, ushort length, out ushort[] value);

        void ReadInt32(string startAddress, ushort length, out int[] value);

        void ReadUInt32(string startAddress, ushort length, out uint[] value);

        void ReadFloat(string startAddress, ushort length, out float[] value);

        void ReadInt64(string startAddress, ushort length, out long[] value);

        void ReadUInt64(string startAddress, ushort length, out ulong[] value);

        void ReadDouble(string startAddress, ushort length, out double[] value);

        void ReadString(string startAddress, ushort length, out string value, Encoding encoding);

        void Write(string address, byte[] value);

        void Write(string address, bool value);

        void Write(string address, bool[] value);

        void Write(string address, double value);

        void Write(string address, double[] value);

        void Write(string address, float value);

        void Write(string address, float[] value);

        void Write(string address, int value);

        void Write(string address, int[] value);

        void Write(string address, long value);

        void Write(string address, long[] value);

        void Write(string address, short value);

        void Write(string address, short[] value);

        void Write(string address, string value, int length, Encoding encoding);

        void Write(string address, ushort value);

        void Write(string address, ushort[] value);

        void Write(string address, uint value);

        void Write(string address, uint[] value);

        void Write(string address, ulong value);

        void Write(string address, ulong[] value);
    }
}
