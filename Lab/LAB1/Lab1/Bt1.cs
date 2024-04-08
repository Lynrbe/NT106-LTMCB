using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Bt1 : Form
    {
        public Bt1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2;
                long sum = 0;
                num1 = Int32.Parse(st1.Text.Trim());
                num2 = Int32.Parse(st2.Text.Trim());
                sum = num1 + num2;
                kq.Text = sum.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Kết quả phép toán bị tràn số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa không?");
            this.st1.Clear(); 
            this.st2.Clear();
            this.kq.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
