namespace LibraryAutomation
{
    partial class Screen_AddBook
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.txt_PageCount = new System.Windows.Forms.TextBox();
            this.cbox_Publisher = new System.Windows.Forms.ComboBox();
            this.cbox_Lang = new System.Windows.Forms.ComboBox();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.cbox_Category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayınevi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dili :";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(94, 6);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(161, 20);
            this.txt_ISBN.TabIndex = 6;
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(94, 32);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(161, 20);
            this.txt_BookName.TabIndex = 7;
            // 
            // txt_PageCount
            // 
            this.txt_PageCount.Location = new System.Drawing.Point(94, 58);
            this.txt_PageCount.Name = "txt_PageCount";
            this.txt_PageCount.Size = new System.Drawing.Size(161, 20);
            this.txt_PageCount.TabIndex = 8;
            // 
            // cbox_Publisher
            // 
            this.cbox_Publisher.FormattingEnabled = true;
            this.cbox_Publisher.Location = new System.Drawing.Point(94, 84);
            this.cbox_Publisher.Name = "cbox_Publisher";
            this.cbox_Publisher.Size = new System.Drawing.Size(161, 21);
            this.cbox_Publisher.TabIndex = 9;
            // 
            // cbox_Lang
            // 
            this.cbox_Lang.FormattingEnabled = true;
            this.cbox_Lang.Location = new System.Drawing.Point(94, 138);
            this.cbox_Lang.Name = "cbox_Lang";
            this.cbox_Lang.Size = new System.Drawing.Size(161, 21);
            this.cbox_Lang.TabIndex = 10;
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(148, 165);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(107, 45);
            this.btn_AddBook.TabIndex = 12;
            this.btn_AddBook.Text = "Ekle";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.Btn_AddBook_Click);
            // 
            // cbox_Category
            // 
            this.cbox_Category.FormattingEnabled = true;
            this.cbox_Category.Location = new System.Drawing.Point(94, 111);
            this.cbox_Category.Name = "cbox_Category";
            this.cbox_Category.Size = new System.Drawing.Size(161, 21);
            this.cbox_Category.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategori :";
            // 
            // Screen_AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 216);
            this.Controls.Add(this.cbox_Category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.cbox_Lang);
            this.Controls.Add(this.cbox_Publisher);
            this.Controls.Add(this.txt_PageCount);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Screen_AddBook";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.Screen_AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.TextBox txt_PageCount;
        private System.Windows.Forms.ComboBox cbox_Publisher;
        private System.Windows.Forms.ComboBox cbox_Lang;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.ComboBox cbox_Category;
        private System.Windows.Forms.Label label5;
    }
}