namespace Lab1
{
    partial class Bt4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            tbNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            kq = new TextBox();
            btnXoa = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(34, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(716, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Decimal", "Binary", "Hexa" });
            comboBox2.Location = new Point(477, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(185, 37);
            comboBox2.TabIndex = 8;
            comboBox2.Tag = "";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Decimal", "Binary", "Hexa" });
            comboBox1.Location = new Point(189, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 37);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(189, 146);
            button1.Name = "button1";
            button1.Size = new Size(473, 38);
            button1.TabIndex = 6;
            button1.Text = "Thực hiện";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(396, 98);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 5;
            label3.Text = "Sang";
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(189, 40);
            tbNumber.Multiline = true;
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(473, 37);
            tbNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 95);
            label2.Name = "label2";
            label2.Size = new Size(63, 29);
            label2.TabIndex = 1;
            label2.Text = "Chọn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 47);
            label1.Name = "label1";
            label1.Size = new Size(133, 29);
            label1.TabIndex = 0;
            label1.Text = "Nhập một số";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(107, 269);
            label4.Name = "label4";
            label4.Size = new Size(84, 29);
            label4.TabIndex = 7;
            label4.Text = "Kết quả";
            // 
            // kq
            // 
            kq.Location = new Point(223, 261);
            kq.Multiline = true;
            kq.Name = "kq";
            kq.ReadOnly = true;
            kq.Size = new Size(527, 37);
            kq.TabIndex = 7;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Comfortaa", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(319, 322);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 43);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Comfortaa", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(525, 322);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 43);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bt4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(kq);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Bt4";
            Text = "Bt4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label3;
        private TextBox tbNumber;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox kq;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnXoa;
        private Button btnThoat;
    }
}