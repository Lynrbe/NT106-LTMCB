using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPServer
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }
        public void serverThread()
        {
            int port = Convert.ToInt32(txtport.Text);
            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, port);
                Byte[] recvByte = udpClient.Receive(ref IpEnd);
                string Data = Encoding.UTF8.GetString(recvByte);
                string mess = IpEnd.Address.ToString() + ":" + IpEnd.Port.ToString() + ": " + Data.ToString();
                rtxbReceivedMess.Invoke(new Action(() => rtxbReceivedMess.Text += mess + "\r\n"));
            }
        }

        private Thread servers;

        private void btnListen_Click(object sender, EventArgs e)
        {
            servers = new Thread(serverThread);
            servers.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (servers != null)
            {
                servers.Interrupt();
                servers.Join();
            }
        }
    }
}
