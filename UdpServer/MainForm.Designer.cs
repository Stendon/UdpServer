namespace UdpServer
{
    partial class MainForm
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
            this.MessageDisplayTextBox = new System.Windows.Forms.RichTextBox();
            this.SendMsgGroupBox = new System.Windows.Forms.GroupBox();
            this.SendMsgTextBox = new System.Windows.Forms.RichTextBox();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.SendMsgButton = new System.Windows.Forms.Button();
            this.SendMsgGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageDisplayTextBox
            // 
            this.MessageDisplayTextBox.Location = new System.Drawing.Point(5, 3);
            this.MessageDisplayTextBox.Name = "MessageDisplayTextBox";
            this.MessageDisplayTextBox.Size = new System.Drawing.Size(592, 246);
            this.MessageDisplayTextBox.TabIndex = 0;
            this.MessageDisplayTextBox.Text = "";
            // 
            // SendMsgGroupBox
            // 
            this.SendMsgGroupBox.Controls.Add(this.SendMsgTextBox);
            this.SendMsgGroupBox.Location = new System.Drawing.Point(5, 254);
            this.SendMsgGroupBox.Name = "SendMsgGroupBox";
            this.SendMsgGroupBox.Size = new System.Drawing.Size(589, 137);
            this.SendMsgGroupBox.TabIndex = 1;
            this.SendMsgGroupBox.TabStop = false;
            this.SendMsgGroupBox.Text = "发送消息";
            // 
            // SendMsgTextBox
            // 
            this.SendMsgTextBox.Location = new System.Drawing.Point(8, 21);
            this.SendMsgTextBox.Name = "SendMsgTextBox";
            this.SendMsgTextBox.Size = new System.Drawing.Size(575, 110);
            this.SendMsgTextBox.TabIndex = 0;
            this.SendMsgTextBox.Text = "";
            this.SendMsgTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnMsgKeyDown);
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindowButton.Location = new System.Drawing.Point(432, 397);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(75, 23);
            this.CloseWindowButton.TabIndex = 2;
            this.CloseWindowButton.Text = "关闭";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.OnCloseWindowButtonClick);
            // 
            // SendMsgButton
            // 
            this.SendMsgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMsgButton.Location = new System.Drawing.Point(519, 397);
            this.SendMsgButton.Name = "SendMsgButton";
            this.SendMsgButton.Size = new System.Drawing.Size(75, 23);
            this.SendMsgButton.TabIndex = 2;
            this.SendMsgButton.Text = "发送";
            this.SendMsgButton.UseVisualStyleBackColor = true;
            this.SendMsgButton.Click += new System.EventHandler(this.OnSendMsgButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 428);
            this.Controls.Add(this.SendMsgButton);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.SendMsgGroupBox);
            this.Controls.Add(this.MessageDisplayTextBox);
            this.Name = "MainForm";
            this.Text = "服务端";
            this.SendMsgGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageDisplayTextBox;
        private System.Windows.Forms.GroupBox SendMsgGroupBox;
        private System.Windows.Forms.RichTextBox SendMsgTextBox;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Button SendMsgButton;
    }
}

