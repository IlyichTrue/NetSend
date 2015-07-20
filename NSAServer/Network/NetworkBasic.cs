using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace NSAServer.Network
{
    internal class NetworkBasic
    {/*
        // TODO: Асинхронная отправка! Или не нужно?
        /// <summary>
        /// Отправить единичное сообщение на единичный хост
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        // internal static void SendMessage(string RemoteHost, string text)
        {
            TcpClient client = null;
            NetworkStream networkStream = null;
            try
            {
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 12000);
                // TODO : заменить 127.0.0.1 на что-то более верное
                // TODO: добавить динамическое выделение портов (из пула свободных портов)
                // получатель сообщения при
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(RemoteHost), 11000);
                // TODO :забить номера портов в настройки
                client = new TcpClient(localEndPoint);
            
                client.Connect(remoteEndPoint);
                
                networkStream = client.GetStream();
                byte[] sendBytes = Encoding.UTF8.GetBytes(text);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
                byte[] bytes = new byte[client.ReceiveBufferSize];
                networkStream.Read(bytes, 0, client.ReceiveBufferSize);
                string returnData = Encoding.UTF8.GetString(bytes);
                //MessageBox.Show(returnData);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (networkStream != null) networkStream.Close();
                if (client!=null) client.Close();
                
                

            }

        }
        */
        // реализаця с UDP
        internal static void SendMessage(string RemoteHost, string text)
        {
            UdpClient client = null;
            try
            {
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 12000);
                
                // получатель сообщения при
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(RemoteHost), 11000);
                // TODO :забить номера портов в настройки
                client = new UdpClient(localEndPoint);
                
                byte[] sendBytes = Encoding.ASCII.GetBytes(text);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
                byte[] bytes = new byte[client.ReceiveBufferSize];
                networkStream.Read(bytes, 0, client.ReceiveBufferSize);
                string returnData = Encoding.UTF8.GetString(bytes);
                //MessageBox.Show(returnData);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (networkStream != null) networkStream.Close();
                if (client != null) client.Close();



            }

        }
    }
}

