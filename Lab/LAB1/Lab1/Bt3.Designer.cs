namespace Lab1
{
    partial class Bt3
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
            label1 = new Label();
            So = new TextBox();
            label2 = new Label();
            kq = new TextBox();
            doc = new Button();
            xoa = new Button();
            thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(381, 33);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9999";
            // 
            // So
            // 
            So.Font = new Font("Comfortaa SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            So.Location = new Point(399, 117);
            So.Name = "So";
            So.Size = new Size(371, 30);
            So.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(143, 223);
            label2.Name = "label2";
            label2.Size = new Size(131, 45);
            label2.TabIndex = 2;
            label2.Text = "Kết quả";
            // 
            // kq
            // 
            kq.Font = new Font("Comfortaa SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kq.Location = new Point(399, 229);
            kq.Name = "kq";
            kq.ReadOnly = true;
            kq.Size = new Size(371, 30);
            kq.TabIndex = 3;
            // 
            // doc
            // 
            doc.Font = new Font("Comfortaa SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            doc.Location = new Point(85, 327);
            doc.Name = "doc";
            doc.Size = new Size(128, 50);
            doc.TabIndex = 4;
            doc.Text = "Đọc";
            doc.UseVisualStyleBackColor = true;
            doc.Click += doc_Click;
            // 
            // xoa
            // 
            xoa.Font = new Font("Comfortaa SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            xoa.Location = new Point(302, 327);
            xoa.Name = "xoa";
            xoa.Size = new Size(128, 50);
            xoa.TabIndex = 5;
            xoa.Text = "Xóa";
            xoa.UseVisualStyleBackColor = true;
            xoa.Click += xoa_Click;
            // 
            // thoat
            // 
            thoat.Font = new Font("Comfortaa SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.Location = new Point(542, 327);
            thoat.Name = "thoat";
            thoat.Size = new Size(128, 50);
            thoat.TabIndex = 6;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // Bt3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(thoat);
            Controls.Add(xoa);
            Controls.Add(doc);
            Controls.Add(kq);
            Controls.Add(label2);
            Controls.Add(So);
            Controls.Add(label1);
            Name = "Bt3";
            Text = "Bt3";
            Load += Bt3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox So;
        private Label label2;
        private TextBox kq;
        private Button doc;
        private Button xoa;
        private Button thoat;
    }
}