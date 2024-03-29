﻿namespace TCPServer2019
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
            this.RadioGotClientAddress = new System.Windows.Forms.RadioButton();
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
            this.ButtonStart.Location = new System.Drawing.Point(536, 401);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 27;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click_1);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(347, 401);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 26;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click_1);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(183, 401);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 25;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click_1);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(97, 283);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(606, 77);
            this.TextMessage.TabIndex = 24;
            // 
            // TextStatus
            // 
            this.TextStatus.Location = new System.Drawing.Point(97, 205);
            this.TextStatus.Multiline = true;
            this.TextStatus.Name = "TextStatus";
            this.TextStatus.Size = new System.Drawing.Size(606, 72);
            this.TextStatus.TabIndex = 23;
            // 
            // RadioGotClientAddress
            // 
            this.RadioGotClientAddress.AutoSize = true;
            this.RadioGotClientAddress.Location = new System.Drawing.Point(328, 30);
            this.RadioGotClientAddress.Name = "RadioGotClientAddress";
            this.RadioGotClientAddress.Size = new System.Drawing.Size(106, 17);
            this.RadioGotClientAddress.TabIndex = 22;
            this.RadioGotClientAddress.TabStop = true;
            this.RadioGotClientAddress.Text = "GotClientAddress";
            this.RadioGotClientAddress.UseVisualStyleBackColor = true;
            // 
            // TextRemotePort
            // 
            this.TextRemotePort.Location = new System.Drawing.Point(462, 160);
            this.TextRemotePort.Name = "TextRemotePort";
            this.TextRemotePort.Size = new System.Drawing.Size(100, 20);
            this.TextRemotePort.TabIndex = 21;
            // 
            // TextRemoteAddress
            // 
            this.TextRemoteAddress.Location = new System.Drawing.Point(208, 155);
            this.TextRemoteAddress.Name = "TextRemoteAddress";
            this.TextRemoteAddress.Size = new System.Drawing.Size(100, 20);
            this.TextRemoteAddress.TabIndex = 20;
            // 
            // LabelRemotePort
            // 
            this.LabelRemotePort.AutoSize = true;
            this.LabelRemotePort.Location = new System.Drawing.Point(387, 163);
            this.LabelRemotePort.Name = "LabelRemotePort";
            this.LabelRemotePort.Size = new System.Drawing.Size(66, 13);
            this.LabelRemotePort.TabIndex = 19;
            this.LabelRemotePort.Text = "Remote Port";
            // 
            // LabelRemoteAddress
            // 
            this.LabelRemoteAddress.AutoSize = true;
            this.LabelRemoteAddress.Location = new System.Drawing.Point(107, 163);
            this.LabelRemoteAddress.Name = "LabelRemoteAddress";
            this.LabelRemoteAddress.Size = new System.Drawing.Size(85, 13);
            this.LabelRemoteAddress.TabIndex = 18;
            this.LabelRemoteAddress.Text = "Remote Address";
            // 
            // LabelLocalPort
            // 
            this.LabelLocalPort.AutoSize = true;
            this.LabelLocalPort.Location = new System.Drawing.Point(388, 94);
            this.LabelLocalPort.Name = "LabelLocalPort";
            this.LabelLocalPort.Size = new System.Drawing.Size(74, 13);
            this.LabelLocalPort.TabIndex = 17;
            this.LabelLocalPort.Text = "Local Address";
            // 
            // LabelLocalAddress
            // 
            this.LabelLocalAddress.AutoSize = true;
            this.LabelLocalAddress.Location = new System.Drawing.Point(104, 94);
            this.LabelLocalAddress.Name = "LabelLocalAddress";
            this.LabelLocalAddress.Size = new System.Drawing.Size(74, 13);
            this.LabelLocalAddress.TabIndex = 16;
            this.LabelLocalAddress.Text = "Local Address";
            // 
            // TextLocalPort
            // 
            this.TextLocalPort.Location = new System.Drawing.Point(462, 88);
            this.TextLocalPort.Name = "TextLocalPort";
            this.TextLocalPort.Size = new System.Drawing.Size(100, 20);
            this.TextLocalPort.TabIndex = 15;
            // 
            // TextLocalAddress
            // 
            this.TextLocalAddress.Location = new System.Drawing.Point(198, 88);
            this.TextLocalAddress.Name = "TextLocalAddress";
            this.TextLocalAddress.Size = new System.Drawing.Size(100, 20);
            this.TextLocalAddress.TabIndex = 14;
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
            this.Controls.Add(this.RadioGotClientAddress);
            this.Controls.Add(this.TextRemotePort);
            this.Controls.Add(this.TextRemoteAddress);
            this.Controls.Add(this.LabelRemotePort);
            this.Controls.Add(this.LabelRemoteAddress);
            this.Controls.Add(this.LabelLocalPort);
            this.Controls.Add(this.LabelLocalAddress);
            this.Controls.Add(this.TextLocalPort);
            this.Controls.Add(this.TextLocalAddress);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.TextBox TextStatus;
        private System.Windows.Forms.RadioButton RadioGotClientAddress;
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

