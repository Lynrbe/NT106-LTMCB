using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPClient
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }

        private void ClientSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            //Lấy địa chỉ IP từ textbox và chuyển thành kiểu IPAddress
            IPAddress ipaddr = IPAddress.Parse(txbipaddr.Text);
            int port =Convert.ToInt32(txbport.Text);
            IPEndPoint ipendp = new IPEndPoint(ipaddr, port);
            //Chuyển chuỗi dữ diệu nhập sang kiểu byte
            Byte[] sendBytes = Encoding.UTF8.GetBytes(rtxbmess.Text);
            //Gởi dữ liệu đến IPEndPoint đã định nghĩa địa chỉ IP và Port
            udpClient.Send(sendBytes, sendBytes.Length, ipendp);
            //Xóa dữ liệu vừa được gửi ở ô nhập
            rtxbmess.Text = " ";
        }
    }
}
