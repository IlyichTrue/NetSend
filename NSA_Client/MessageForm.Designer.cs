namespace NSA_Client
{
    partial class MessageForm
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
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.lb_MessageText = new System.Windows.Forms.Label();
            this.b_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Icon
            // 
            this.pb_Icon.Location = new System.Drawing.Point(12, 12);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(100, 100);
            this.pb_Icon.TabIndex = 0;
            this.pb_Icon.TabStop = false;
            // 
            // lb_MessageText
            // 
            this.lb_MessageText.AutoSize = true;
            this.lb_MessageText.Location = new System.Drawing.Point(133, 13);
            this.lb_MessageText.Name = "lb_MessageText";
            this.lb_MessageText.Size = new System.Drawing.Size(35, 13);
            this.lb_MessageText.TabIndex = 1;
            this.lb_MessageText.Text = "label1";
            // 
            // b_Ok
            // 
            this.b_Ok.Location = new System.Drawing.Point(208, 88);
            this.b_Ok.Name = "b_Ok";
            this.b_Ok.Size = new System.Drawing.Size(75, 23);
            this.b_Ok.TabIndex = 2;
            this.b_Ok.Text = "OK";
            this.b_Ok.UseVisualStyleBackColor = true;
            this.b_Ok.Click += new System.EventHandler(this.b_Ok_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 123);
            this.Controls.Add(this.b_Ok);
            this.Controls.Add(this.lb_MessageText);
            this.Controls.Add(this.pb_Icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Label lb_MessageText;
        private System.Windows.Forms.Button b_Ok;
    }
}