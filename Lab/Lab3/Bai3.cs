using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
          
            TCP_Server tcpServer = new TCP_Server();
            tcpServer.Show();
            //tcpServer = null;
            //this.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            TCP_Client tcpClient = new TCP_Client();
            tcpClient.Show();
            //tcpClient = null;
            //this.Show();
        }

    }
}
