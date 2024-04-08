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
using System.IO;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string folderPath = fbd.SelectedPath;
            DirectoryInfo di = new DirectoryInfo(folderPath);
            FileInfo[] files = di.GetFiles();
            lvThumuc.Items.Clear();
            foreach(FileInfo file in files)
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Length.ToString());
                item.SubItems.Add(file.CreationTime.ToString());
                item.SubItems.Add(file.Extension);
                lvThumuc.Items.Add(item);
            }
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            lvThumuc.View = View.Details;
            lvThumuc.Columns.Add("Tên File", 400);
            lvThumuc.Columns.Add("Kích thước (bytes)", 150);
            lvThumuc.Columns.Add("Đuôi mở rộng", 200);
            lvThumuc.Columns.Add("Ngày tạo", 200);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
