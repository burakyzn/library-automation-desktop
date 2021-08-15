namespace LibraryAutomation
{
    partial class Screen_Books
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_SearchBook = new System.Windows.Forms.Button();
            this.btn_DeleteBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.data_BookList = new System.Windows.Forms.DataGridView();
            this.btn_AddAuthors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_BookList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(491, 292);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(194, 53);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_SearchBook
            // 
            this.btn_SearchBook.Location = new System.Drawing.Point(491, 52);
            this.btn_SearchBook.Name = "btn_SearchBook";
            this.btn_SearchBook.Size = new System.Drawing.Size(194, 53);
            this.btn_SearchBook.TabIndex = 20;
            this.btn_SearchBook.Text = "Ara";
            this.btn_SearchBook.UseVisualStyleBackColor = true;
            this.btn_SearchBook.Click += new System.EventHandler(this.Btn_SearchBook_Click);
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.Location = new System.Drawing.Point(491, 233);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.Size = new System.Drawing.Size(194, 53);
            this.btn_DeleteBook.TabIndex = 19;
            this.btn_DeleteBook.Text = "Sil";
            this.btn_DeleteBook.UseVisualStyleBackColor = true;
            this.btn_DeleteBook.Click += new System.EventHandler(this.Btn_DeleteBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kitaplar :";
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(547, 9);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(138, 20);
            this.txt_BookName.TabIndex = 17;
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(491, 111);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(194, 53);
            this.btn_AddBook.TabIndex = 16;
            this.btn_AddBook.Text = "Ekle";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.Btn_AddBook_Click);
            // 
            // data_BookList
            // 
            this.data_BookList.AllowUserToAddRows = false;
            this.data_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_BookList.Location = new System.Drawing.Point(12, 12);
            this.data_BookList.Name = "data_BookList";
            this.data_BookList.ReadOnly = true;
            this.data_BookList.Size = new System.Drawing.Size(470, 333);
            this.data_BookList.TabIndex = 15;
            // 
            // btn_AddAuthors
            // 
            this.btn_AddAuthors.Location = new System.Drawing.Point(491, 170);
            this.btn_AddAuthors.Name = "btn_AddAuthors";
            this.btn_AddAuthors.Size = new System.Drawing.Size(194, 53);
            this.btn_AddAuthors.TabIndex = 22;
            this.btn_AddAuthors.Text = "Yazarları Ekle";
            this.btn_AddAuthors.UseVisualStyleBackColor = true;
            this.btn_AddAuthors.Click += new System.EventHandler(this.Btn_AddAuthors_Click);
            // 
            // Screen_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 357);
            this.Controls.Add(this.btn_AddAuthors);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_SearchBook);
            this.Controls.Add(this.btn_DeleteBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BookName);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.data_BookList);
            this.Name = "Screen_Books";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Screen_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_BookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_SearchBook;
        private System.Windows.Forms.Button btn_DeleteBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.DataGridView data_BookList;
        private System.Windows.Forms.Button btn_AddAuthors;
    }
}