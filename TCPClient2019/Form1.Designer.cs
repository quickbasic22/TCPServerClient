namespace TCPClient2019
{
    partial class Form1
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.TextStatus = new System.Windows.Forms.TextBox();
            this.RadioGotServerAddress = new System.Windows.Forms.RadioButton();
            this.TextRemotePort = new System.Windows.Forms.TextBox();
            this.TextRemoteAddress = new System.Windows.Forms.TextBox();
            this.LabelRemotePort = new System.Windows.Forms.Label();
            this.LabelRemoteAddress = new System.Windows.Forms.Label();
            this.LabelLocalPort = new System.Windows.Forms.Label();
            this.LabelLocalAddress = new System.Windows.Forms.Label();
            this.TextLocalPort = new System.Windows.Forms.TextBox();
            this.TextLocalAddress = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(536, 399);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 41;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click_1);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(347, 399);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 40;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click_1);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(183, 399);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 39;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(97, 281);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(606, 77);
            this.TextMessage.TabIndex = 38;
            // 
            // TextStatus
            // 
            this.TextStatus.Location = new System.Drawing.Point(97, 203);
            this.TextStatus.Multiline = true;
            this.TextStatus.Name = "TextStatus";
            this.TextStatus.Size = new System.Drawing.Size(606, 72);
            this.TextStatus.TabIndex = 37;
            // 
            // RadioGotServerAddress
            // 
            this.RadioGotServerAddress.AutoSize = true;
            this.RadioGotServerAddress.Location = new System.Drawing.Point(328, 28);
            this.RadioGotServerAddress.Name = "RadioGotServerAddress";
            this.RadioGotServerAddress.Size = new System.Drawing.Size(111, 17);
            this.RadioGotServerAddress.TabIndex = 36;
            this.RadioGotServerAddress.TabStop = true;
            this.RadioGotServerAddress.Text = "GotServerAddress";
            this.RadioGotServerAddress.UseVisualStyleBackColor = true;
            // 
            // TextRemotePort
            // 
            this.TextRemotePort.Location = new System.Drawing.Point(462, 158);
            this.TextRemotePort.Name = "TextRemotePort";
            this.TextRemotePort.Size = new System.Drawing.Size(100, 20);
            this.TextRemotePort.TabIndex = 35;
            // 
            // TextRemoteAddress
            // 
            this.TextRemoteAddress.Location = new System.Drawing.Point(208, 153);
            this.TextRemoteAddress.Name = "TextRemoteAddress";
            this.TextRemoteAddress.Size = new System.Drawing.Size(100, 20);
            this.TextRemoteAddress.TabIndex = 34;
            // 
            // LabelRemotePort
            // 
            this.LabelRemotePort.AutoSize = true;
            this.LabelRemotePort.Location = new System.Drawing.Point(387, 161);
            this.LabelRemotePort.Name = "LabelRemotePort";
            this.LabelRemotePort.Size = new System.Drawing.Size(66, 13);
            this.LabelRemotePort.TabIndex = 33;
            this.LabelRemotePort.Text = "Remote Port";
            // 
            // LabelRemoteAddress
            // 
            this.LabelRemoteAddress.AutoSize = true;
            this.LabelRemoteAddress.Location = new System.Drawing.Point(107, 161);
            this.LabelRemoteAddress.Name = "LabelRemoteAddress";
            this.LabelRemoteAddress.Size = new System.Drawing.Size(85, 13);
            this.LabelRemoteAddress.TabIndex = 32;
            this.LabelRemoteAddress.Text = "Remote Address";
            // 
            // LabelLocalPort
            // 
            this.LabelLocalPort.AutoSize = true;
            this.LabelLocalPort.Location = new System.Drawing.Point(388, 92);
            this.LabelLocalPort.Name = "LabelLocalPort";
            this.LabelLocalPort.Size = new System.Drawing.Size(74, 13);
            this.LabelLocalPort.TabIndex = 31;
            this.LabelLocalPort.Text = "Local Address";
            // 
            // LabelLocalAddress
            // 
            this.LabelLocalAddress.AutoSize = true;
            this.LabelLocalAddress.Location = new System.Drawing.Point(104, 92);
            this.LabelLocalAddress.Name = "LabelLocalAddress";
            this.LabelLocalAddress.Size = new System.Drawing.Size(74, 13);
            this.LabelLocalAddress.TabIndex = 30;
            this.LabelLocalAddress.Text = "Local Address";
            // 
            // TextLocalPort
            // 
            this.TextLocalPort.Location = new System.Drawing.Point(462, 86);
            this.TextLocalPort.Name = "TextLocalPort";
            this.TextLocalPort.Size = new System.Drawing.Size(100, 20);
            this.TextLocalPort.TabIndex = 29;
            // 
            // TextLocalAddress
            // 
            this.TextLocalAddress.Location = new System.Drawing.Point(198, 86);
            this.TextLocalAddress.Name = "TextLocalAddress";
            this.TextLocalAddress.Size = new System.Drawing.Size(100, 20);
            this.TextLocalAddress.TabIndex = 28;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.TextStatus);
            this.Controls.Add(this.RadioGotServerAddress);
            this.Controls.Add(this.TextRemotePort);
            this.Controls.Add(this.TextRemoteAddress);
            this.Controls.Add(this.LabelRemotePort);
            this.Controls.Add(this.LabelRemoteAddress);
            this.Controls.Add(this.LabelLocalPort);
            this.Controls.Add(this.LabelLocalAddress);
            this.Controls.Add(this.TextLocalPort);
            this.Controls.Add(this.TextLocalAddress);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.TextBox TextStatus;
        private System.Windows.Forms.RadioButton RadioGotServerAddress;
        private System.Windows.Forms.TextBox TextRemotePort;
        private System.Windows.Forms.TextBox TextRemoteAddress;
        private System.Windows.Forms.Label LabelRemotePort;
        private System.Windows.Forms.Label LabelRemoteAddress;
        private System.Windows.Forms.Label LabelLocalPort;
        private System.Windows.Forms.Label LabelLocalAddress;
        private System.Windows.Forms.TextBox TextLocalPort;
        private System.Windows.Forms.TextBox TextLocalAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

