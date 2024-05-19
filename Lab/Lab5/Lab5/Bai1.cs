using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            string mailfrom = tbemailfr.Text.ToString().Trim();
            string mailto = tbemailto.Text.ToString().Trim();
            string password = "tzhphtlafgndhwyf";
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mailfrom, password),
                EnableSsl = true
            };

            var message = new MailMessage();
            MailAddress fromAddress = new MailAddress(mailfrom);
            message.From = fromAddress;
            message.To.Add(mailto);
            message.Subject = tbsubject.Text.ToString().Trim();
            message.IsBodyHtml = true;
            message.Body = rtbbody.Text.ToString();
            try
            {
                client.Send(message);
                MessageBox.Show("The message is succesfully sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

    }
}
