using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace NSAServer
{
     //TODO: Добавить отображение статуса хоста
    //TODO: добавить проверку, находится ли хост в сети
    public partial class NewMessageForm : Form
    {
        public NewMessageForm()
        {
            InitializeComponent();
        }

        private void b_SendMessage_Click(object sender, EventArgs e)
        {
             //Создать сообщение
             
            Message message = new Message(textBox1.Text, MessageLevel.Information); 
            // TODO: добавить разные messagelevel в зависимости от выбраного уровня в окне создания сообщения

            //Создать список адресатов
            //Отправить созданное сообщение списку адресатов
            List<string> addresslist = new List<string>(checkedListBox1.Items.Cast<string>());
            
            Sender MessageSender = new Sender(addresslist.ToArray(),message);
            MessageSender.Send();
        }

        private void NewMessageForm_Load(object sender, EventArgs e)
        {
            rb_Information.Image = SystemIcons.Information.ToBitmap();
            
            textBox1.Text = string.Format("Тестовое сообщение! Сейчас {0}", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));;
        }
    }
}
