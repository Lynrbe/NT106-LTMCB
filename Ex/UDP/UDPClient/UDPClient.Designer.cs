namespace UDPClient
{
    partial class UDPClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbipaddr = new System.Windows.Forms.TextBox();
            this.txbport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxbmess = new System.Windows.Forms.RichTextBox();
            this.ClientSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Remote Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txbipaddr
            // 
            this.txbipaddr.Font = new System.Drawing.Font("Comfortaa SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbipaddr.Location = new System.Drawing.Point(33, 72);
            this.txbipaddr.Name = "txbipaddr";
            this.txbipaddr.Size = new System.Drawing.Size(257, 26);
            this.txbipaddr.TabIndex = 3;
            // 
            // txbport
            // 
            this.txbport.Font = new System.Drawing.Font("Comfortaa SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbport.Location = new System.Drawing.Point(496, 72);
            this.txbport.Name = "txbport";
            this.txbport.Size = new System.Drawing.Size(155, 26);
            this.txbport.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // rtxbmess
            // 
            this.rtxbmess.Location = new System.Drawing.Point(33, 149);
            this.rtxbmess.Name = "rtxbmess";
            this.rtxbmess.Size = new System.Drawing.Size(696, 195);
            this.rtxbmess.TabIndex = 6;
            this.rtxbmess.Text = "";
            // 
            // ClientSend
            // 
            this.ClientSend.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSend.Location = new System.Drawing.Point(298, 363);
            this.ClientSend.Name = "ClientSend";
            this.ClientSend.Size = new System.Drawing.Size(161, 53);
            this.ClientSend.TabIndex = 7;
            this.ClientSend.Text = "Send";
            this.ClientSend.UseVisualStyleBackColor = true;
            this.ClientSend.Click += new System.EventHandler(this.ClientSend_Click);
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientSend);
            this.Controls.Add(this.rtxbmess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbport);
            this.Controls.Add(this.txbipaddr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UDPClient";
            this.Text = "CLIENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbipaddr;
        private System.Windows.Forms.TextBox txbport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxbmess;
        private System.Windows.Forms.Button ClientSend;
    }
}

