using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Bt2 : Form
    {
        public Bt2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Tìm số lớn nhất
                float num1, num2, num3;
                num1 = float.Parse(st1.Text);
                num2 = float.Parse(st2.Text);
                num3 = float.Parse(st3.Text);
               kqLN.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
               
                //Tìm số nhỏ nhất
                
               kqNN.Text = Math.Min(num1, Math.Min(num2, num3)).ToString();
              

            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Dữ liệu nhập vào bị tràn số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Xóa giá trị trong các textbox
            MessageBox.Show("Bạn có chắc chắn muốn xóa không?");
            st1.Clear();
            st2.Clear();
            st3.Clear();
            kqLN.Clear();
            kqNN.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
