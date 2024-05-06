using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class TCP_Server_B4 : Form
    {
        Thread serverThread;
        Thread clientThread;
        List<TcpClient> clients;
        bool Isrunning = true;
        TcpListener server;
        public TCP_Server_B4()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.serverThread = new Thread(new ThreadStart(startServer));
            serverThread.Start();
            richTextBox1.AppendText("Server running on 127.0.0.1:8080 \r\n");
        }
        private void startServer()
        {
            TcpClient TCP_lient;
            clients = new List<TcpClient>();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            server = new TcpListener(iPEndPoint);
            server.Start();
            try
            {
                while (Isrunning)
                {
                    TCP_lient = server.AcceptTcpClient();
                    clients.Add(TCP_lient);
                    richTextBox1.AppendText($"New client connected from:{TCP_lient.Client.RemoteEndPoint.ToString()} \r\n");
                    clientThread = new Thread(() => handleClient(TCP_lient));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void handleClient(TcpClient Client)
        {
            try
            {
                while (Client.Connected)
                {
                    byte[] buffer = new byte[1024];
                    Stream receive = Client.GetStream();
                    int bytesReceived = receive.Read(buffer, 0, buffer.Length);
                    string text = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                    if (text == "Quit")
                    {
                        //MessageBox.Show(text);
                        Client.Close();
                        clients.Remove(Client);
                    }
                    else
                    {
                        richTextBox1.AppendText(text + "\n");
                        sendBroadcast(Client, text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sendBroadcast(TcpClient Client, string text)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (Client != clients[i])
                {
                    //MessageBox.Show(i.ToString());
                    NetworkStream ns = clients[i].GetStream();
                    byte[] buffer = Encoding.UTF8.GetBytes(text);
                    ns.Write(buffer, 0, buffer.Length);
                }
            }
        }

        private void TCPserverB4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Isrunning = false;
            server.Stop();
        }

    }
}
