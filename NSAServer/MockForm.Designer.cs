namespace NSAServer
{
    partial class MockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MockForm));
            this.cms_tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ts_newMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_PrevMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.nI_tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_tray.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_tray
            // 
            this.cms_tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_newMessage,
            this.ts_PrevMessages,
            this.ts_Options,
            this.ts_About,
            this.ts_Separator,
            this.ts_Exit});
            this.cms_tray.Name = "cms_tray";
            this.cms_tray.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cms_tray.Size = new System.Drawing.Size(203, 142);
            // 
            // ts_newMessage
            // 
            this.ts_newMessage.Name = "ts_newMessage";
            this.ts_newMessage.Size = new System.Drawing.Size(202, 22);
            this.ts_newMessage.Text = "Новое сообщение";
            this.ts_newMessage.Click += new System.EventHandler(this.ts_newMessage_Click);
            // 
            // ts_PrevMessages
            // 
            this.ts_PrevMessages.Name = "ts_PrevMessages";
            this.ts_PrevMessages.Size = new System.Drawing.Size(202, 22);
            this.ts_PrevMessages.Text = "Последние сообщения";
            // 
            // ts_Options
            // 
            this.ts_Options.Name = "ts_Options";
            this.ts_Options.Size = new System.Drawing.Size(202, 22);
            this.ts_Options.Text = "Настройки";
            // 
            // ts_About
            // 
            this.ts_About.Name = "ts_About";
            this.ts_About.Size = new System.Drawing.Size(202, 22);
            this.ts_About.Text = "О программе";
            // 
            // ts_Separator
            // 
            this.ts_Separator.Name = "ts_Separator";
            this.ts_Separator.Size = new System.Drawing.Size(199, 6);
            // 
            // ts_Exit
            // 
            this.ts_Exit.Name = "ts_Exit";
            this.ts_Exit.Size = new System.Drawing.Size(202, 22);
            this.ts_Exit.Text = "Выход";
            // 
            // nI_tray
            // 
            this.nI_tray.ContextMenuStrip = this.cms_tray;
            this.nI_tray.Icon = ((System.Drawing.Icon)(resources.GetObject("nI_tray.Icon")));
            this.nI_tray.Text = "notifyIcon1";
            this.nI_tray.Visible = true;
            this.nI_tray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nI_tray_MouseClick);
            // 
            // MockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 780);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MockForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.cms_tray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cms_tray;
        private System.Windows.Forms.NotifyIcon nI_tray;
        private System.Windows.Forms.ToolStripMenuItem ts_newMessage;
        private System.Windows.Forms.ToolStripMenuItem ts_PrevMessages;
        private System.Windows.Forms.ToolStripMenuItem ts_Options;
        private System.Windows.Forms.ToolStripMenuItem ts_About;
        private System.Windows.Forms.ToolStripSeparator ts_Separator;
        private System.Windows.Forms.ToolStripMenuItem ts_Exit;
    }
}