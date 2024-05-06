namespace Lab3
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
            this.btnUDPS = new System.Windows.Forms.Button();
            this.btnUDPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUDPS
            // 
            this.btnUDPS.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDPS.Location = new System.Drawing.Point(39, 60);
            this.btnUDPS.Name = "btnUDPS";
            this.btnUDPS.Size = new System.Drawing.Size(214, 77);
            this.btnUDPS.TabIndex = 0;
            this.btnUDPS.Text = "UDP Server";
            this.btnUDPS.UseVisualStyleBackColor = true;
            this.btnUDPS.Click += new System.EventHandler(this.btnUDPS_Click);
            // 
            // btnUDPC
            // 
            this.btnUDPC.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDPC.Location = new System.Drawing.Point(489, 60);
            this.btnUDPC.Name = "btnUDPC";
            this.btnUDPC.Size = new System.Drawing.Size(214, 77);
            this.btnUDPC.TabIndex = 1;
            this.btnUDPC.Text = "UDP Client";
            this.btnUDPC.UseVisualStyleBackColor = true;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 187);
            this.Controls.Add(this.btnUDPC);
            this.Controls.Add(this.btnUDPS);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUDPS;
        private System.Windows.Forms.Button btnUDPC;
    }
}