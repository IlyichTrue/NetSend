using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NSA_Client
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(NSAServer.Message message) : this()
        {
            lb_MessageText.Text = message.Text;
            switch (message.Level)
            {
                    //установка изображения в зависимости от типа сообщения 
                case NSAServer.MessageLevel.Error: pb_Icon.Image = SystemIcons.Error.ToBitmap(); break;
                case NSAServer.MessageLevel.Information: pb_Icon.Image = SystemIcons.Information.ToBitmap(); break;
                case NSAServer.MessageLevel.Question: pb_Icon.Image = SystemIcons.Question.ToBitmap(); break;
                case NSAServer.MessageLevel.Warning: pb_Icon.Image = SystemIcons.Warning.ToBitmap(); break;
            }
            
        }

        public void ShowSomethins()
        {
           
            this.Show();
        }

        private void b_Ok_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }


    }
}
