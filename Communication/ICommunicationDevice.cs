using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Communication
{
    public interface ICommunicationDevice
    {
        /// <summary>
        /// 通信实例名称
        /// </summary>
        public string DisplayName { get; }
        public int Id { get; set; }
        public void Open();
        public void Close();
        public void Send(string message);
        public void Send(byte[] bytes);

    }
}
