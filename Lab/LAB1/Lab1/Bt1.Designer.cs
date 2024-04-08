namespace Lab1
{
    partial class Bt1
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            st1 = new TextBox();
            st2 = new TextBox();
            kq = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(759, 300);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(147, 44);
            button1.TabIndex = 0;
            button1.Text = "Tính tổng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 39);
            label1.TabIndex = 1;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(214, 219);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 39);
            label2.TabIndex = 2;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(234, 305);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 39);
            label3.TabIndex = 3;
            label3.Text = "Kết quả";
            // 
            // st1
            // 
            st1.Location = new Point(380, 156);
            st1.Margin = new Padding(4);
            st1.Name = "st1";
            st1.Size = new Size(316, 24);
            st1.TabIndex = 4;
            // 
            // st2
            // 
            st2.Location = new Point(380, 234);
            st2.Margin = new Padding(4);
            st2.Name = "st2";
            st2.Size = new Size(316, 24);
            st2.TabIndex = 5;
            // 
            // kq
            // 
            kq.Location = new Point(380, 312);
            kq.Margin = new Padding(4);
            kq.Name = "kq";
            kq.ReadOnly = true;
            kq.Size = new Size(316, 24);
            kq.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa SemiBold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(190, 35);
            label4.Name = "label4";
            label4.Size = new Size(608, 68);
            label4.TabIndex = 7;
            label4.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // button2
            // 
            button2.Location = new Point(70, 368);
            button2.Name = "button2";
            button2.Size = new Size(109, 69);
            button2.TabIndex = 8;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(286, 368);
            button3.Name = "button3";
            button3.Size = new Size(109, 69);
            button3.TabIndex = 9;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Bt1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 540);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(kq);
            Controls.Add(st2);
            Controls.Add(st1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Comfortaa SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Bt1";
            Text = "Bt1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox st1;
        private TextBox st2;
        private TextBox kq;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}