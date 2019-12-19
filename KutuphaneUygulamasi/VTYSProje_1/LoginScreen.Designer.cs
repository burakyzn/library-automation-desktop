namespace VTYSProje_1
{
    partial class Screen_Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RegisterStudent = new System.Windows.Forms.Button();
            this.btn_RegisterStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(85, 74);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(89, 46);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Giriş Yap";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(85, 12);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(279, 20);
            this.txt_kullaniciAdi.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(85, 38);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(279, 20);
            this.txt_sifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // btn_RegisterStudent
            // 
            this.btn_RegisterStudent.Location = new System.Drawing.Point(180, 74);
            this.btn_RegisterStudent.Name = "btn_RegisterStudent";
            this.btn_RegisterStudent.Size = new System.Drawing.Size(89, 46);
            this.btn_RegisterStudent.TabIndex = 5;
            this.btn_RegisterStudent.Text = "Öğrenci Kayıt";
            this.btn_RegisterStudent.UseVisualStyleBackColor = true;
            this.btn_RegisterStudent.Click += new System.EventHandler(this.Btn_RegisterStudent_Click);
            // 
            // btn_RegisterStaff
            // 
            this.btn_RegisterStaff.Location = new System.Drawing.Point(275, 74);
            this.btn_RegisterStaff.Name = "btn_RegisterStaff";
            this.btn_RegisterStaff.Size = new System.Drawing.Size(89, 46);
            this.btn_RegisterStaff.TabIndex = 6;
            this.btn_RegisterStaff.Text = "Personel Kayıt";
            this.btn_RegisterStaff.UseVisualStyleBackColor = true;
            this.btn_RegisterStaff.Click += new System.EventHandler(this.Btn_RegisterStaff_Click);
            // 
            // Screen_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 132);
            this.Controls.Add(this.btn_RegisterStaff);
            this.Controls.Add(this.btn_RegisterStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.btn_Login);
            this.Name = "Screen_Login";
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RegisterStudent;
        private System.Windows.Forms.Button btn_RegisterStaff;
    }
}

