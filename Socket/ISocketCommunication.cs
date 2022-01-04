namespace IntellVega.CBB.Interfaces.Socket
{
    public interface ISocketCommunication
    {
        void InitSocket();

        void Received(System.Net.Sockets.Socket socketRecive);

        void Send(string message);
    }
}
