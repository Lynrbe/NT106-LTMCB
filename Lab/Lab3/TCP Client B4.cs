using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class TCP_Client_B4 : Form
    {
        TcpClient tcpClient;
        NetworkStream stream;
        IPEndPoint ipEndPoint;
        Thread receiveThread;
        public TCP_Client_B4()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.Start();
            
        }
        public void Disconnect()
        {
            try
            {
                if (tcpClient != null)
                {
                    stream = tcpClient.GetStream();
                    byte[] buffer = Encoding.UTF8.GetBytes("Quit");
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            catch { }
            if (stream != null)
            {
                stream.Close();
                tcpClient.Close();
            }
        }
        public void Connect()
        {
            try
            {
                tcpClient = new TcpClient();
                ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                tcpClient.Connect(ipEndPoint);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Send()
        {
            stream = tcpClient.GetStream();
            //byte[] buffer = new byte[1024];
            byte[] buffer = Encoding.UTF8.GetBytes(rtbName.Text + ": " + rtbText.Text + "\n");
            stream.Write(buffer, 0, buffer.Length);
            richTextBox1.AppendText(rtbName.Text + ": " + rtbText.Text + "\n");
           // richTextBox1.Clear();
        }
        public void Receive()
        {
            while (tcpClient.Connected)
            {
                try
                {
                    stream = tcpClient.GetStream();
                    byte[] buffer = new byte[1024];
                    stream.Read(buffer, 0, buffer.Length);
                    richTextBox1.AppendText(Encoding.UTF8.GetString(buffer) + "\r\n");
                }
                catch
                {
                    //tcpClient.Close();
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tcpClient != null)
            {
                Send();
                rtbText.Clear();
            }
            else
            {
                MessageBox.Show("Don't connect to server!");
            }
        }

    }
}
