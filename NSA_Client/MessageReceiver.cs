using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using NSAServer;
using NSA_Client;



namespace NSA_Client
{
    //TODO : Добавить выход на логику обработки сообщений. Составить формат обмена сообщениями
    class MessageReceiver
    {

        class ConnectionInfo
        {
            public Socket Socket { get; set; }
            public byte[] Buffer { get; set; }
            public const int BufferSize = 1024;
            public StringBuilder inputString;
            private NSAServer.Message message;  // сообщение, которое будет передаваться 
        }

        private Socket _serverSocket { get; set; }
        private int _serverPort { get; set; }

        public MessageReceiver () : this(5777) {/* Если порт не указан, по умолчанию использовать 5777*/}
       
        public MessageReceiver(int port)
        {
            _serverPort = port;
        }

        private List<ConnectionInfo> _connections  = new List<ConnectionInfo>();

        public void Start()
        {
            SetupServerSocket();
            for (int i = 0; i < 10; i++)
            {
                _serverSocket.BeginAccept(AcceptCallback, _serverSocket);
            }
        }
        private void SetupServerSocket ()
        {
            //IPHostEntry localmachineInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPHostEntry localmachineInfo = Dns.GetHostEntry("127.0.0.1");
            //IPEndPoint ServerEndPoint = new IPEndPoint(localmachineInfo.AddressList[0], _serverPort);
            IPEndPoint ServerEndPoint = new IPEndPoint(new IPAddress(new byte[] { 127, 0, 0, 1 }), _serverPort);
            _serverSocket = new Socket(ServerEndPoint.Address.AddressFamily,SocketType.Stream,ProtocolType.Tcp);
            _serverSocket.Bind(ServerEndPoint);
            _serverSocket.Listen(30);

        }

        private void AcceptCallback (IAsyncResult state)
        {
            ConnectionInfo connection = new ConnectionInfo();

            try
            {
                Socket socket = (Socket) state.AsyncState;
                connection.Socket = socket.EndAccept(state);
                connection.Buffer = new byte[ConnectionInfo.BufferSize];
                lock (_connections) _connections.Add(connection);
                connection.Socket.BeginReceive(connection.Buffer, 0, connection.Buffer.Length, 0, DataReadCallback,
                                               connection);
                _serverSocket.BeginAccept(AcceptCallback, state.AsyncState);
            }
            catch (SocketException e )
            {
                CloseConnection(connection);
               MessageBox.Show(String.Format("Socket exception : {0}", e.SocketErrorCode));
            }

            catch (Exception e)
            {
                CloseConnection(connection);
                MessageBox.Show(String.Format("exception : {0}", e.Message));
            }
        }

        /// <summary>
        /// Вызывается при приеме сообщения на сокет (?)
        /// </summary>
        /// <param name="state"></param>
        private void DataReadCallback(IAsyncResult state)
        {
            ConnectionInfo connection = (ConnectionInfo) state.AsyncState;
            if (connection.inputString == null) connection.inputString = new StringBuilder();
            
            try
            {
                int bytesRead = connection.Socket.EndReceive(state);
                if (bytesRead > 0)
                {
                    connection.inputString.Append(Encoding.UTF8.GetString(connection.Buffer));
                    connection.Buffer = new byte[ConnectionInfo.BufferSize];
                    string content = connection.inputString.ToString().Trim();
                    if (content.IndexOf("<EOF>") > -1)
                    {
                        string content_strip = content.Remove(content.IndexOf("<EOF>"));
                        byte[] bytes = Convert.FromBase64String(content_strip);
 
                        MemoryStream deserializationStream = new MemoryStream(bytes);
                        deserializationStream.Position = 0;
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        NSAServer.Message message = (NSAServer.Message)binaryFormatter.Deserialize(deserializationStream);
                        
                        byte[] answer = Encoding.UTF8.GetBytes("принято");
                        
                        MessageForm frm = new MessageForm(message);

                        Thread MessageShowThread = new Thread(new ParameterizedThreadStart(ShowForm));
                        MessageShowThread.Start(message);
                        MessageBox.Show(String.Format("Текст : {0}. Уровень : {1}",message.Text, message.Level));
                        connection.Socket.BeginSend(answer, 0, answer.Length, 0, DataSendCallback, connection);
                    }
                        
                    else
                    {
                        connection.Socket.BeginReceive(connection.Buffer, 0, connection.Buffer.Length, 0,
                                                       DataReadCallback, connection);
                    }
                }
            }
            catch (SocketException e)
            {
                CloseConnection(connection);
                MessageBox.Show(String.Format("Socket exception : {0}", e.SocketErrorCode));
            }

            catch (Exception e)
            {
                CloseConnection(connection);
                MessageBox.Show(String.Format("exception : {0}", e.Message));
            }
        }

        private void DataSendCallback (IAsyncResult state)
        {
            ConnectionInfo  connection = (ConnectionInfo) state.AsyncState;
            try
            {
                Socket Socket = connection.Socket;
                int bytesSent = Socket.EndSend(state);
                Socket.Shutdown(SocketShutdown.Both);
                CloseConnection(connection);
            }
            catch (SocketException e)
            {
                CloseConnection(connection);
                MessageBox.Show(String.Format("Socket exception : {0}", e.SocketErrorCode));
            }

            catch (Exception e)
            {
                CloseConnection(connection);
                MessageBox.Show(String.Format("exception : {0}", e.Message));
            }
            
        }

        private void CloseConnection(ConnectionInfo connection)
        {
            connection.Socket.Close();
            lock (_connections) _connections.Remove(connection);
        }

        private void ShowForm(object message)
        { 

            using(MessageForm MessageForm = new MessageForm(message as NSAServer.Message)) Application.Run(MessageForm);
        }


    }
}
