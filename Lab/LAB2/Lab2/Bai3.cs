using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnDocF_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                if (!ofd.SafeFileName.EndsWith(".txt"))
                {
                    throw new ArgumentException("File không đúng định dạng .txt! Vui lòng chọn lại!");
                }
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fs.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình đọc file đã xảy ra lỗi!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhiF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text (*.txt) | *.txt";
                sfd.ShowDialog();

                //Tính toán
                string content = richTextBox1.Text;
                string[] line = content.Split('\n');
                string output = string.Empty;

                DataTable dt = new DataTable();
                foreach (string l in line)
                {
                    object result = dt.Compute(l, "");
                    output = output + l + " = " + result + "\n";
                }
                richTextBox1.Text = output;

                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                byte[] ct = Encoding.UTF8.GetBytes(richTextBox1.Text);

                //richTextBox1.Clear();

                fs.Write(ct, 0, ct.Length);
                MessageBox.Show("Quá trình ghi file đã hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình đọc file đã xảy ra lỗi!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
