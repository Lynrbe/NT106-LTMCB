namespace Lab5
{
    partial class Bai1
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
            System.Windows.Forms.Label label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.btSend = new System.Windows.Forms.Button();
            this.tbemailfr = new System.Windows.Forms.TextBox();
            this.tbemailto = new System.Windows.Forms.TextBox();
            this.tbsubject = new System.Windows.Forms.TextBox();
            this.rtbbody = new System.Windows.Forms.RichTextBox();
            label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(25, 25);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(142, 89);
            this.btSend.TabIndex = 0;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(215, 31);
            label.Name = "label";
            label.Size = new System.Drawing.Size(63, 25);
            label.TabIndex = 1;
            label.Text = "From:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(215, 98);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 25);
            label1.TabIndex = 2;
            label1.Text = "To:";
            // 
            // tbemailfr
            // 
            this.tbemailfr.Location = new System.Drawing.Point(284, 25);
            this.tbemailfr.Multiline = true;
            this.tbemailfr.Name = "tbemailfr";
            this.tbemailfr.Size = new System.Drawing.Size(330, 39);
            this.tbemailfr.TabIndex = 3;
            // 
            // tbemailto
            // 
            this.tbemailto.Location = new System.Drawing.Point(284, 84);
            this.tbemailto.Multiline = true;
            this.tbemailto.Name = "tbemailto";
            this.tbemailto.Size = new System.Drawing.Size(330, 39);
            this.tbemailto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 153);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 25);
            label2.TabIndex = 5;
            label2.Text = "Subject:";
            // 
            // tbsubject
            // 
            this.tbsubject.Location = new System.Drawing.Point(130, 139);
            this.tbsubject.Multiline = true;
            this.tbsubject.Name = "tbsubject";
            this.tbsubject.Size = new System.Drawing.Size(842, 39);
            this.tbsubject.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 208);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 25);
            label3.TabIndex = 7;
            label3.Text = "Body:";
            // 
            // rtbbody
            // 
            this.rtbbody.Location = new System.Drawing.Point(135, 216);
            this.rtbbody.Name = "rtbbody";
            this.rtbbody.Size = new System.Drawing.Size(836, 305);
            this.rtbbody.TabIndex = 8;
            this.rtbbody.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.rtbbody);
            this.Controls.Add(label3);
            this.Controls.Add(this.tbsubject);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbemailto);
            this.Controls.Add(this.tbemailfr);
            this.Controls.Add(label1);
            this.Controls.Add(label);
            this.Controls.Add(this.btSend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbemailfr;
        private System.Windows.Forms.TextBox tbemailto;
        private System.Windows.Forms.TextBox tbsubject;
        private System.Windows.Forms.RichTextBox rtbbody;
    }
}