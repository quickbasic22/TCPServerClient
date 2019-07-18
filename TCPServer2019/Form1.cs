using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer2019
{
    public partial class Form1 : Form
    {
        private Boolean done = true;
        private TcpListener server;
        private ArrayList arrayList;
        private IPEndPoint groupEP;
        private IPEndPoint localEP;
        private IPEndPoint remoteEP;
        private IPAddress[] myaddresses;
        private BinaryFormatter bf;
        private MemoryStream memoryStream;



        public Form1()
        {
            InitializeComponent();
            arrayList = new ArrayList();


        }

        public void StartServer()
        {

            if (TextLocalAddress.Text == "")
            {
                myaddresses = Dns.GetHostAddresses(Dns.GetHostName());
                localEP = new IPEndPoint(myaddresses[1], 56000);
                TextLocalAddress.Text = localEP.Address.ToString();
                TextLocalPort.Text = localEP.Port.ToString();
            }
            localEP = new IPEndPoint(IPAddress.Parse(TextLocalAddress.Text), int.Parse(TextLocalPort.Text));


            try
            {
                server = new TcpListener(localEP);
                server.Start();
                
                TextMessage.Text += "Server started...";
                TextMessage.Text += "\r\n";

            }
            catch (Exception ex)
            {
                TextMessage.Text += ex.ToString();
                TextMessage.Text += ex.Message.ToString();
                
            }

        }

        
        public void Send()
        {
            if (server.Server.Connected)
            {
                remoteEP = new IPEndPoint(IPAddress.Broadcast, 56001);
                ButtonSend.Enabled = false;

                bf = new BinaryFormatter();
                arrayList.Add(DateTime.Now);
                arrayList.Add("Server");
                arrayList.Add(TextMessage.Text);
                string mystring = string.Format("user: {0} message: {1}, this message sent on {2}", arrayList[1], arrayList[2], arrayList[0]);
                arrayList.Add(mystring);
                memoryStream = new MemoryStream();
                bf.Serialize(memoryStream, arrayList);
                byte[] bytesToSend = memoryStream.ToArray();
                try
                {
                    //server.Client.SendTo(bytesToSend, remoteEP);
                }
                catch (Exception ex)
                {
                    TextMessage.Text += ex.ToString();
                    TextMessage.Text += ex.Message.ToString();
                }

                TextMessage.Text += "\r\n";
                TextMessage.Text += "Data Sent";
                TextMessage.Text += "\r\n";
                TextMessage.Text = "";
                Thread.Sleep(2000);
                ButtonSend.Enabled = true;

            }

        }

       
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (server.Server.Connected)
            {
                try
                {
                    while (done)
                    {
                        byte[] buffer = new byte[200];
                        groupEP = null;
                        groupEP = new IPEndPoint(IPAddress.Any, 56001);
                        bf = new BinaryFormatter();
                        TextMessage.Text += "\r\n";
                        TextMessage.Text += "Waiting for Data...";
                        TextMessage.Text += "\r\n";
                        int result = server.Server.Receive(buffer);
                        TextMessage.Text += "\r\n";
                        TextMessage.Text += string.Format("Received broadcast from {0}", groupEP.ToString());
                        TextMessage.Text += "\r\n";
                        RadioGotClientAddress.Checked = true;
                        memoryStream = new MemoryStream(buffer);
                        memoryStream.Position = 0;
                        ArrayList myobject = (ArrayList)bf.Deserialize(memoryStream);
                        TextMessage.Text += myobject[2].ToString();


                    }

                }
                catch (Exception ex)
                {
                    TextMessage.Text += "\r\n";
                    TextMessage.Text += ex.ToString();
                    TextMessage.Text += "\r\n";
                    TextMessage.Text += ex.Message;
                    TextMessage.Text += "\r\n";


                }
                TextMessage.Text += "\r\n";
                TextMessage.Text += "Exiting Receive";
                TextMessage.Text += "\r\n";
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void ButtonClose_Click_1(object sender, EventArgs e)
        {
            server.Server.Close();
            server.Server.Dispose();
            ButtonClose.Enabled = false;

            Thread.Sleep(2000);
            ButtonClose.Enabled = true;
            ButtonStart.Enabled = true;

        }

        private void ButtonSend_Click_1(object sender, EventArgs e)
        {
            Send();

            ButtonSend.Enabled = false;
            Thread.Sleep(2000);
            ButtonSend.Enabled = true;
        }

        private void ButtonStart_Click_1(object sender, EventArgs e)
        {
            StartServer();
            ButtonStart.Enabled = false;

        }
    }
}
