using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsThreadsTest
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Thread frmthread = new Thread(startNewThread);
            frmthread.Start();
        }

        private void startNewThread()
        {
            using ( AnotherForm frm = new AnotherForm())
            {
                Application.Run(frm);
            }
        }
    }
}
