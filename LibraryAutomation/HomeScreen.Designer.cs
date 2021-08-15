namespace LibraryAutomation
{
    partial class Screen_Home
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
            this.components = new System.ComponentModel.Container();
            this.btn_SearchBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MemberNo = new System.Windows.Forms.Label();
            this.lbl_MemberNick = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_AdminPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SearchBook
            // 
            this.btn_SearchBook.Location = new System.Drawing.Point(12, 34);
            this.btn_SearchBook.Name = "btn_SearchBook";
            this.btn_SearchBook.Size = new System.Drawing.Size(133, 63);
            this.btn_SearchBook.TabIndex = 1;
            this.btn_SearchBook.Text = "Kitap Ara";
            this.btn_SearchBook.UseVisualStyleBackColor = true;
            this.btn_SearchBook.Click += new System.EventHandler(this.Btn_SearchBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // lbl_MemberNo
            // 
            this.lbl_MemberNo.AutoSize = true;
            this.lbl_MemberNo.Location = new System.Drawing.Point(67, 9);
            this.lbl_MemberNo.Name = "lbl_MemberNo";
            this.lbl_MemberNo.Size = new System.Drawing.Size(11, 13);
            this.lbl_MemberNo.TabIndex = 4;
            this.lbl_MemberNo.Text = "*";
            // 
            // lbl_MemberNick
            // 
            this.lbl_MemberNick.AutoSize = true;
            this.lbl_MemberNick.Location = new System.Drawing.Point(202, 9);
            this.lbl_MemberNick.Name = "lbl_MemberNick";
            this.lbl_MemberNick.Size = new System.Drawing.Size(11, 13);
            this.lbl_MemberNick.TabIndex = 5;
            this.lbl_MemberNick.Text = "*";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btn_AdminPanel
            // 
            this.btn_AdminPanel.Location = new System.Drawing.Point(12, 103);
            this.btn_AdminPanel.Name = "btn_AdminPanel";
            this.btn_AdminPanel.Size = new System.Drawing.Size(133, 63);
            this.btn_AdminPanel.TabIndex = 6;
            this.btn_AdminPanel.Text = "Admin Paneli";
            this.btn_AdminPanel.UseVisualStyleBackColor = true;
            this.btn_AdminPanel.Click += new System.EventHandler(this.Btn_AdminPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kitap Bağışla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(151, 103);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(133, 63);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "Çıkış Yap";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Screen_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 177);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AdminPanel);
            this.Controls.Add(this.lbl_MemberNick);
            this.Controls.Add(this.lbl_MemberNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SearchBook);
            this.Name = "Screen_Home";
            this.Text = "Yönetim Sistemi";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SearchBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MemberNo;
        private System.Windows.Forms.Label lbl_MemberNick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_AdminPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Logout;
    }
}