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
    public partial class Bai4 : Form
    {

        public Bai4()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            TCP_Server_B4 tcpServerb4 = new TCP_Server_B4();
            tcpServerb4.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            TCP_Client_B4 tcpClientb4 = new TCP_Client_B4();
            tcpClientb4.Show();
        }
    }
}
