namespace LibraryAutomation
{
    partial class Screen_AddPublisher
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
            this.btn_AddPublisher = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_WebURL = new System.Windows.Forms.TextBox();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.txt_publisherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_AddPublisher
            // 
            this.btn_AddPublisher.Location = new System.Drawing.Point(130, 218);
            this.btn_AddPublisher.Name = "btn_AddPublisher";
            this.btn_AddPublisher.Size = new System.Drawing.Size(100, 46);
            this.btn_AddPublisher.TabIndex = 25;
            this.btn_AddPublisher.Text = "Ekle";
            this.btn_AddPublisher.UseVisualStyleBackColor = true;
            this.btn_AddPublisher.Click += new System.EventHandler(this.Btn_AddPublisher_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(89, 166);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(141, 20);
            this.txt_email.TabIndex = 24;
            // 
            // txt_WebURL
            // 
            this.txt_WebURL.Location = new System.Drawing.Point(89, 192);
            this.txt_WebURL.Name = "txt_WebURL";
            this.txt_WebURL.Size = new System.Drawing.Size(141, 20);
            this.txt_WebURL.TabIndex = 23;
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Location = new System.Drawing.Point(89, 38);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(141, 20);
            this.txt_phoneNo.TabIndex = 21;
            // 
            // txt_publisherName
            // 
            this.txt_publisherName.Location = new System.Drawing.Point(89, 12);
            this.txt_publisherName.Name = "txt_publisherName";
            this.txt_publisherName.Size = new System.Drawing.Size(141, 20);
            this.txt_publisherName.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Web URL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adres :";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(89, 64);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(141, 96);
            this.txt_address.TabIndex = 28;
            this.txt_address.Text = "";
            // 
            // Screen_AddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 274);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_AddPublisher);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_WebURL);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.txt_publisherName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Screen_AddPublisher";
            this.Text = "Yayınevi Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddPublisher;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_WebURL;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.TextBox txt_publisherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_address;
    }
}