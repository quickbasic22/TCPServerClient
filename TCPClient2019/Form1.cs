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

namespace TCPClient2019
{
    public partial class Form1 : Form
    {
        
         private TcpClient Client;
        private IPEndPoint localEP;
        private IPEndPoint remoteEP;
        private Boolean done = true;
        private ArrayList arrayList;
        private IPEndPoint groupEP;
        private BinaryFormatter bf;
        private MemoryStream memoryStream;
        private Thread sendThread;
        private Thread receiveThread;
        private Boolean gotServerAddress = false;
        private string StatusText;
        private IPAddress[] myaddresses;


        public Form1()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
            arrayList = new ArrayList();


        }

       
        private void Startup()
        {

            if (TextLocalAddress.Text == "")
            {
                myaddresses = Dns.GetHostAddresses(Dns.GetHostName());
                localEP = new IPEndPoint(myaddresses[1], 56001);
                TextLocalAddress.Text = localEP.Address.ToString();
                TextLocalPort.Text = localEP.Port.ToString();
            }


            localEP = new IPEndPoint(IPAddress.Parse(TextLocalAddress.Text), int.Parse(TextLocalPort.Text));
            Client = new TcpClient(localEP);
            Client.Client.EnableBroadcast = true;
            TextStatus.Text += "\r\n";
            TextStatus.Text += "Client Started up";
            TextStatus.Text += "\r\n";

            remoteEP = new IPEndPoint(localEP.Address, 56000);

            try
            {
                Client.Connect(remoteEP);
            }
            catch (SocketException ex)
            {
                TextStatus.Text += ex.ToString();
                TextStatus.Text += ex.Message.ToString();
            }
        }

       
        private void Send()
        { 
            if (Client.Connected)
            {
                remoteEP = null;
                remoteEP = new IPEndPoint(IPAddress.Broadcast, 56000);
                arrayList.Add(DateTime.Now);
                arrayList.Add("Client");
                arrayList.Add(TextMessage.Text);
                string mystring = string.Format("user: {0}, message: {1}, this message sent on {2}", arrayList[1], arrayList[2], arrayList[0]);
                arrayList.Add(mystring);
                memoryStream = new MemoryStream();
                bf = new BinaryFormatter();
                bf.Serialize(memoryStream, arrayList);
                byte[] bytesToSend = memoryStream.ToArray();
                if (remoteEP != null)
                {
                    try
                    {
                        Client.Client.SendTo(bytesToSend, remoteEP);
                    }
                    catch (Exception ex)
                    {
                        TextStatus.Text += ex.ToString();
                        TextStatus.Text += ex.Message.ToString();

                    }

                    TextStatus.Text += "\r\n";
                    TextStatus.Text += "Data Sent";
                    TextStatus.Text += "\r\n";
                    TextMessage.Text = "";
                }



            }

        }

       
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Client.Connected)
            {
                try
                {
                    while (done)
                    {
                        byte[] buffer = new byte[200];
                        groupEP = null;
                        groupEP = new IPEndPoint(IPAddress.Any, 0);
                        arrayList = new ArrayList();
                        bf = new BinaryFormatter();
                        //byte[] bytes = Client.Receive(ref groupEP);
                        RadioGotServerAddress.Checked = true;
                        int result = Client.Client.Receive(buffer);
                        TextStatus.Text += "\r\n";
                        TextStatus.Text += string.Format("Received broadcast from {0}", groupEP.ToString());
                        TextStatus.Text += "\r\n";
                        memoryStream = new MemoryStream(buffer);
                        memoryStream.Position = 0;
                        ArrayList myobject = new ArrayList();
                        myobject = (ArrayList)bf.Deserialize(memoryStream);
                        TextMessage.Text += myobject[2].ToString();
                        done = false;


                    }
                }
                catch (Exception ex)
                {
                    TextStatus.Text += ex.ToString();
                    TextStatus.Text += "\r\n";
                    TextStatus.Text += ex.Message;
                    TextStatus.Text += "\r\n";

                }
                TextMessage.Text += "\r\n";
                TextMessage.Text += "Exiting Receive";
                TextMessage.Text += "\r\n";
            }
            

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Client.Close();
            Client.Dispose();
            ButtonClose.Enabled = false;
            Thread.Sleep(2000);
            ButtonClose.Enabled = true;
            ButtonStart.Enabled = true;
        }

        private void ButtonSend_Click_1(object sender, EventArgs e)
        {
            ButtonSend.Enabled = false;
            Send();
            Thread.Sleep(2000);
            ButtonSend.Enabled = true;

        }

        private void ButtonStart_Click_1(object sender, EventArgs e)
        {
            ButtonStart.Enabled = false;
            Startup();
            Thread.Sleep(2000);
            ButtonStart.Enabled = false;

        }
    }
}
