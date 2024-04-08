using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
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
                    //Tên
                    string name = ofd.SafeFileName.ToString();
                    tbTen.Text = name;
                    //URL
                    string link = fs.Name.ToString();
                    tbUrl.Text = link;
                    //Đếm số ký tự

                    int charCount = content.Length;
                    tbKitu.Text = charCount.ToString();
                    //Đếm số dòng
                    content = content.Replace("\r\n", "\r");
                    int lineCount = richTextBox1.Lines.Count();
                    content = content.Replace('\r', ' ');
                    tbDong.Text = lineCount.ToString();
                    //Đếm số từ
                    string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    int wordCount = source.Count();
                    tbTu.Text = wordCount.ToString();
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
    }
}
