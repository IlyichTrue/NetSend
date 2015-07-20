using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace NSAServer
{
    /// <summary>
    /// Класс для посылки сообщений
    /// </summary>
    class Sender
    {
        private IPAddress[] AddressList;
        private Message Message;

        public enum MessageType
        {
            PingRequest,
            PingReply,
            Message,
            MessageReceived,
            MessageRead,
            SendAgain
        }

        internal static void SendMessage()
        {
            throw new NotImplementedException();
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list">Список адресов</param>
        public Sender (string [] addresslist, string MessageText)
        {
            this.Message = new Message(MessageText, MessageLevel.Information);

            AddressList = new IPAddress[addresslist.Count()];
            for (int i = 0; i < addresslist.Count(); i++)
            {
                AddressList[i] = Dns.GetHostEntry(addresslist[i]).AddressList[0];
            }
        }

        public Sender (string [] addresslist, Message Message)
        {
            this.Message = Message;
            AddressList = new IPAddress[addresslist.Count()];
            for (int i = 0; i < addresslist.Count(); i++)
            {
                //AddressList[i] = Dns.GetHostEntry(addresslist[i]).AddressList[i].;
                AddressList[i] = new IPAddress(new byte[] { 127, 0, 0, 1 }); 
            }
        }

        /// <summary>
        /// отправить сообщение адресатам
        /// </summary>
       public void Send (MessageType messageType)
       {
           // Сериализовать объект Message
           // Создать объект, хранящий данные Message
           // Отправить этот объект
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();

            binaryFormatter.Serialize(memoryStream, Message);
            memoryStream.Position = 0;
            string data = Convert.ToBase64String(memoryStream.ToArray());
            data += "<EOF>"; //TODO: Избавиться от необходимости использования EOF! Нужно также исправить в MessageReceiver'е
           foreach (var ipAddress in AddressList)
           {
               Network.NetworkBasic.SendMessage(ipAddress.ToString(), data);
              
           }
           
       }

        

    }

    
}
