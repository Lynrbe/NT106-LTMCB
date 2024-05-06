namespace Lab3
{
    partial class TCP_Client_B4
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(37, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(729, 214);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // rtbName
            // 
            this.rtbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbName.Location = new System.Drawing.Point(37, 276);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(351, 58);
            this.rtbName.TabIndex = 1;
            this.rtbName.Text = "";
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Location = new System.Drawing.Point(37, 349);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(542, 90);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(398, 276);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(181, 41);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(585, 363);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(181, 41);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // TCP_Client_B4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 467);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.rtbName);
            this.Controls.Add(this.richTextBox1);
            this.Name = "TCP_Client_B4";
            this.Text = "TCP_Client_B4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox rtbName;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
    }
}