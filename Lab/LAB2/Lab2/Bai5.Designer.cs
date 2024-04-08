namespace Lab2
{
    partial class Bai5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            this.lvThumuc = new System.Windows.Forms.ListView();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvThumuc
            // 
            resources.ApplyResources(this.lvThumuc, "lvThumuc");
            this.lvThumuc.HideSelection = false;
            this.lvThumuc.Name = "lvThumuc";
            this.lvThumuc.UseCompatibleStateImageBehavior = false;
            // 
            // btnChon
            // 
            resources.ApplyResources(this.btnChon, "btnChon");
            this.btnChon.Name = "btnChon";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Bai5
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lvThumuc);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Bai5";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvThumuc;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThoat;
    }
}