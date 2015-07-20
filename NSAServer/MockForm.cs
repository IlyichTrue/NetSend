using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NSAServer
{
    // Форма нужна для поддержания notifyIcon, contextMenuStrip

    public partial class MockForm : Form
    {
        public MockForm()
        {
            InitializeComponent();
        }

        private void nI_tray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                Point point = new Point(MousePosition.X, MousePosition.Y);
                cms_tray.Show(point);
                
            }
        }

        private void ts_newMessage_Click(object sender, EventArgs e)
        {
            NewMessageForm NewMessageForm = new NewMessageForm();
            NewMessageForm.Show();
        }
    }
}
