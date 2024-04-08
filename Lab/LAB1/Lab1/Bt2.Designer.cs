namespace Lab1
{
    partial class Bt2
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
            label2 = new Label();
            label3 = new Label();
            st1 = new TextBox();
            st2 = new TextBox();
            st3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            kqLN = new TextBox();
            label5 = new Label();
            kqNN = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 139);
            label1.Name = "label1";
            label1.Size = new Size(161, 38);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(322, 139);
            label2.Name = "label2";
            label2.Size = new Size(143, 38);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comfortaa SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(616, 139);
            label3.Name = "label3";
            label3.Size = new Size(136, 38);
            label3.TabIndex = 2;
            label3.Text = "Số thứ ba";
            // 
            // st1
            // 
            st1.Location = new Point(177, 150);
            st1.Name = "st1";
            st1.Size = new Size(139, 27);
            st1.TabIndex = 3;
            // 
            // st2
            // 
            st2.Location = new Point(471, 150);
            st2.Name = "st2";
            st2.Size = new Size(139, 27);
            st2.TabIndex = 4;
            // 
            // st3
            // 
            st3.Location = new Point(758, 150);
            st3.Name = "st3";
            st3.Size = new Size(139, 27);
            st3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(192, 219);
            button1.Name = "button1";
            button1.Size = new Size(105, 51);
            button1.TabIndex = 6;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 219);
            button2.Name = "button2";
            button2.Size = new Size(105, 51);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(627, 219);
            button3.Name = "button3";
            button3.Size = new Size(105, 51);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comfortaa SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 342);
            label4.Name = "label4";
            label4.Size = new Size(158, 38);
            label4.TabIndex = 9;
            label4.Text = "Số lớn nhất";
            // 
            // kqLN
            // 
            kqLN.Location = new Point(210, 353);
            kqLN.Name = "kqLN";
            kqLN.ReadOnly = true;
            kqLN.Size = new Size(139, 27);
            kqLN.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comfortaa SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(533, 342);
            label5.Name = "label5";
            label5.Size = new Size(168, 38);
            label5.TabIndex = 11;
            label5.Text = "Số nhỏ nhất";
            // 
            // kqNN
            // 
            kqNN.Location = new Point(707, 353);
            kqNN.Name = "kqNN";
            kqNN.ReadOnly = true;
            kqNN.Size = new Size(139, 27);
            kqNN.TabIndex = 12;
            // 
            // Bt2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 450);
            Controls.Add(kqNN);
            Controls.Add(label5);
            Controls.Add(kqLN);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(st3);
            Controls.Add(st2);
            Controls.Add(st1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bt2";
            Text = "Bt2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox st1;
        private TextBox st2;
        private TextBox st3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox kqLN;
        private Label label5;
        private TextBox kqNN;
    }
}