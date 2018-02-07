using System.Net;

namespace NthDeveloper.TelnetServer
{
    public delegate void ClientConnectionEventHandler(ITCPServer server, ClientInfo client);
    public delegate void ClientDataEventHandler(ITCPServer server, ClientInfo client, byte[] data);

    public interface ITCPServer
    {
        int MaxWaitingClients { get; set; }
        int ReadBufferSize { get; set; }

        event ClientConnectionEventHandler ClientConnected;
        event ClientConnectionEventHandler ClientDisconnected;
        event ClientDataEventHandler DataReceived;

        void StartListening(IPEndPoint endPoint);
        void StopListening();
    }
}