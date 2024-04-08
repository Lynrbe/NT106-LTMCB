namespace Lab2
{
    partial class Bai3
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
            this.btnDocF = new System.Windows.Forms.Button();
            this.btnGhiF = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDocF
            // 
            this.btnDocF.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocF.Location = new System.Drawing.Point(35, 91);
            this.btnDocF.Name = "btnDocF";
            this.btnDocF.Size = new System.Drawing.Size(157, 62);
            this.btnDocF.TabIndex = 0;
            this.btnDocF.Text = "ĐỌC FILE";
            this.btnDocF.UseVisualStyleBackColor = true;
            this.btnDocF.Click += new System.EventHandler(this.btnDocF_Click);
            // 
            // btnGhiF
            // 
            this.btnGhiF.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiF.Location = new System.Drawing.Point(35, 243);
            this.btnGhiF.Name = "btnGhiF";
            this.btnGhiF.Size = new System.Drawing.Size(157, 62);
            this.btnGhiF.TabIndex = 1;
            this.btnGhiF.Text = "GHI FILE";
            this.btnGhiF.UseVisualStyleBackColor = true;
            this.btnGhiF.Click += new System.EventHandler(this.btnGhiF_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(212, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(540, 334);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnGhiF);
            this.Controls.Add(this.btnDocF);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocF;
        private System.Windows.Forms.Button btnGhiF;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}