using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace test
{
    class AsynchronousIoServer
    {
        private Socket _serverSocket;
        private int _port;

        private class ConnectionInfo
        {
            public Socket Socket;
            public byte[] Buffer;
        }

        public AsynchronousIoServer(int port) { _port = port; }

        private List<ConnectionInfo> _connections = new List<ConnectionInfo>(); 
        
        public void Start()
        {
            SetupServerSocket();
            for (int i = 0; i < 10; i++)
            {
                _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), _serverSocket);
            }
        }

        private void SetupServerSocket()
        {
            // Получаем информацию о локальном компьютере
            IPHostEntry localMachineInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPEndPoint myEndpoint = new IPEndPoint(localMachineInfo.AddressList[0], _port);

            // Создаем сокет, привязываем его к адресу
            // и начинаем прослушивание
            _serverSocket = new Socket(myEndpoint.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(myEndpoint);
            _serverSocket.Listen((int) SocketOptionName.MaxConnections);
        }

        private void AcceptCallback(IAsyncResult result)
        {
            ConnectionInfo connection = new ConnectionInfo();

            try
            {
                Socket s = (Socket) result.AsyncState;
                connection.Socket = s.EndAccept(result);
                connection.Buffer = new byte[255];
                lock (_connections) _connections.Add(connection);

                connection.Socket.BeginReceive(connection.Buffer, 0, connection.Buffer.Length, SocketFlags.None,
                                               new AsyncCallback(ReceiveCallback), connection);
            }
        }

    }
}
