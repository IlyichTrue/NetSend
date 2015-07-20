namespace NSAServer
{
    partial class NewMessageForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_SendMessage = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rb_Information = new System.Windows.Forms.RadioButton();
            this.rb_Warning = new System.Windows.Forms.RadioButton();
            this.rb_Error = new System.Windows.Forms.RadioButton();
            this.rb_Question = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 172);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 61);
            this.textBox1.TabIndex = 0;
            // 
            // b_SendMessage
            // 
            this.b_SendMessage.Location = new System.Drawing.Point(398, 244);
            this.b_SendMessage.Name = "b_SendMessage";
            this.b_SendMessage.Size = new System.Drawing.Size(75, 23);
            this.b_SendMessage.TabIndex = 1;
            this.b_SendMessage.Text = "Отправить";
            this.b_SendMessage.UseVisualStyleBackColor = true;
            this.b_SendMessage.Click += new System.EventHandler(this.b_SendMessage_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "127.0.0.1",
            "127.0.0.1",
            "127.0.0.1",
            "127.0.0.1"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(178, 154);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // rb_Information
            // 
            this.rb_Information.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Information.AutoSize = true;
            this.rb_Information.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_Information.Location = new System.Drawing.Point(13, 240);
            this.rb_Information.Name = "rb_Information";
            this.rb_Information.Size = new System.Drawing.Size(83, 23);
            this.rb_Information.TabIndex = 3;
            this.rb_Information.TabStop = true;
            this.rb_Information.Text = "Информация";
            this.rb_Information.UseVisualStyleBackColor = true;
            // 
            // rb_Warning
            // 
            this.rb_Warning.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Warning.AutoSize = true;
            this.rb_Warning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_Warning.Location = new System.Drawing.Point(12, 269);
            this.rb_Warning.Name = "rb_Warning";
            this.rb_Warning.Size = new System.Drawing.Size(104, 23);
            this.rb_Warning.TabIndex = 4;
            this.rb_Warning.TabStop = true;
            this.rb_Warning.Text = "Предупреждение";
            this.rb_Warning.UseVisualStyleBackColor = true;
            // 
            // rb_Error
            // 
            this.rb_Error.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Error.AutoSize = true;
            this.rb_Error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_Error.Location = new System.Drawing.Point(122, 240);
            this.rb_Error.Name = "rb_Error";
            this.rb_Error.Size = new System.Drawing.Size(57, 23);
            this.rb_Error.TabIndex = 5;
            this.rb_Error.TabStop = true;
            this.rb_Error.Text = "Ошибка";
            this.rb_Error.UseVisualStyleBackColor = true;
            // 
            // rb_Question
            // 
            this.rb_Question.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Question.AutoSize = true;
            this.rb_Question.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_Question.Location = new System.Drawing.Point(122, 269);
            this.rb_Question.Name = "rb_Question";
            this.rb_Question.Size = new System.Drawing.Size(54, 23);
            this.rb_Question.TabIndex = 6;
            this.rb_Question.TabStop = true;
            this.rb_Question.Text = "Вопрос";
            this.rb_Question.UseVisualStyleBackColor = true;
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 298);
            this.Controls.Add(this.rb_Question);
            this.Controls.Add(this.rb_Error);
            this.Controls.Add(this.rb_Warning);
            this.Controls.Add(this.rb_Information);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.b_SendMessage);
            this.Controls.Add(this.textBox1);
            this.Name = "NewMessageForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NewMessageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_SendMessage;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton rb_Information;
        private System.Windows.Forms.RadioButton rb_Warning;
        private System.Windows.Forms.RadioButton rb_Error;
        private System.Windows.Forms.RadioButton rb_Question;
    }
}

