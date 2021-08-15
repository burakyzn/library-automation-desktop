namespace LibraryAutomation
{
    partial class Screen_Admin
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
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_Publishers = new System.Windows.Forms.Button();
            this.btn_Languages = new System.Windows.Forms.Button();
            this.btn_Members = new System.Windows.Forms.Button();
            this.btn_Authors = new System.Windows.Forms.Button();
            this.btn_DonatedBooks = new System.Windows.Forms.Button();
            this.btn_Informations = new System.Windows.Forms.Button();
            this.btn_Categories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Books
            // 
            this.btn_Books.Location = new System.Drawing.Point(12, 12);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(153, 56);
            this.btn_Books.TabIndex = 0;
            this.btn_Books.Text = "Kitaplar";
            this.btn_Books.UseVisualStyleBackColor = true;
            this.btn_Books.Click += new System.EventHandler(this.Btn_Books_Click);
            // 
            // btn_Publishers
            // 
            this.btn_Publishers.Location = new System.Drawing.Point(171, 12);
            this.btn_Publishers.Name = "btn_Publishers";
            this.btn_Publishers.Size = new System.Drawing.Size(153, 56);
            this.btn_Publishers.TabIndex = 1;
            this.btn_Publishers.Text = "Yayınevleri";
            this.btn_Publishers.UseVisualStyleBackColor = true;
            this.btn_Publishers.Click += new System.EventHandler(this.Btn_Publishers_Click);
            // 
            // btn_Languages
            // 
            this.btn_Languages.Location = new System.Drawing.Point(330, 12);
            this.btn_Languages.Name = "btn_Languages";
            this.btn_Languages.Size = new System.Drawing.Size(153, 56);
            this.btn_Languages.TabIndex = 4;
            this.btn_Languages.Text = "Diller";
            this.btn_Languages.UseVisualStyleBackColor = true;
            this.btn_Languages.Click += new System.EventHandler(this.Btn_Languages_Click);
            // 
            // btn_Members
            // 
            this.btn_Members.Location = new System.Drawing.Point(12, 74);
            this.btn_Members.Name = "btn_Members";
            this.btn_Members.Size = new System.Drawing.Size(153, 56);
            this.btn_Members.TabIndex = 5;
            this.btn_Members.Text = "Kullanıcılar";
            this.btn_Members.UseVisualStyleBackColor = true;
            this.btn_Members.Click += new System.EventHandler(this.Btn_Members_Click);
            // 
            // btn_Authors
            // 
            this.btn_Authors.Location = new System.Drawing.Point(171, 74);
            this.btn_Authors.Name = "btn_Authors";
            this.btn_Authors.Size = new System.Drawing.Size(153, 56);
            this.btn_Authors.TabIndex = 6;
            this.btn_Authors.Text = "Yazarlar";
            this.btn_Authors.UseVisualStyleBackColor = true;
            this.btn_Authors.Click += new System.EventHandler(this.Btn_Authors_Click);
            // 
            // btn_DonatedBooks
            // 
            this.btn_DonatedBooks.Location = new System.Drawing.Point(330, 74);
            this.btn_DonatedBooks.Name = "btn_DonatedBooks";
            this.btn_DonatedBooks.Size = new System.Drawing.Size(153, 56);
            this.btn_DonatedBooks.TabIndex = 7;
            this.btn_DonatedBooks.Text = "Bağışlanan Kitaplar";
            this.btn_DonatedBooks.UseVisualStyleBackColor = true;
            this.btn_DonatedBooks.Click += new System.EventHandler(this.Btn_DonatedBooks_Click);
            // 
            // btn_Informations
            // 
            this.btn_Informations.Location = new System.Drawing.Point(12, 136);
            this.btn_Informations.Name = "btn_Informations";
            this.btn_Informations.Size = new System.Drawing.Size(153, 56);
            this.btn_Informations.TabIndex = 8;
            this.btn_Informations.Text = "Genel Bilgiler";
            this.btn_Informations.UseVisualStyleBackColor = true;
            this.btn_Informations.Click += new System.EventHandler(this.Btn_Informations_Click);
            // 
            // btn_Categories
            // 
            this.btn_Categories.Location = new System.Drawing.Point(171, 136);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.Size = new System.Drawing.Size(153, 56);
            this.btn_Categories.TabIndex = 9;
            this.btn_Categories.Text = "Kategoriler";
            this.btn_Categories.UseVisualStyleBackColor = true;
            this.btn_Categories.Click += new System.EventHandler(this.Btn_Categories_Click);
            // 
            // Screen_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 248);
            this.Controls.Add(this.btn_Categories);
            this.Controls.Add(this.btn_Informations);
            this.Controls.Add(this.btn_DonatedBooks);
            this.Controls.Add(this.btn_Authors);
            this.Controls.Add(this.btn_Members);
            this.Controls.Add(this.btn_Languages);
            this.Controls.Add(this.btn_Publishers);
            this.Controls.Add(this.btn_Books);
            this.Name = "Screen_Admin";
            this.Text = "Admin Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Button btn_Publishers;
        private System.Windows.Forms.Button btn_Languages;
        private System.Windows.Forms.Button btn_Members;
        private System.Windows.Forms.Button btn_Authors;
        private System.Windows.Forms.Button btn_DonatedBooks;
        private System.Windows.Forms.Button btn_Informations;
        private System.Windows.Forms.Button btn_Categories;
    }
}