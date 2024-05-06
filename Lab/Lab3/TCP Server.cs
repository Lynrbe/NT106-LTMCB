using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class TCP_Server : Form
    {
        public TCP_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;

            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();
        }
        void StartUnsafeThread()
        {
            try
            {
                richTextBox1.AppendText("Waiting for connetion...\n");
                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                richTextBox1.AppendText("Server is running on " + ipepServer.Address + ":" + ipepServer.Port + "\n");
                int bytesReceived = 0;

                byte[] recv = new byte[1];

                Socket clientSocket;
                Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(-1);
                //btnListen.Text = "Listening";
                clientSocket = listenerSocket.Accept();

                richTextBox1.AppendText("New client connected.\r\n");

                while (true)
                {
                    string text = "";
                    do
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        text += Encoding.UTF8.GetString(recv, 0, bytesReceived);
                    }
                    while (text[text.Length - 1] != '\n');

                    if (bytesReceived == 0)
                    {
                        richTextBox1.AppendText("Connection closed by client.");
                        btnListen.Text = "Listen";
                        break;
                    }
                    
                    richTextBox1.AppendText(text);
                }

                listenerSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TCP_Server_Load(object sender, EventArgs e)
        {

        }
    }
}
