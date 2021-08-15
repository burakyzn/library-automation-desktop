namespace LibraryAutomation
{
    partial class Screen_AddAuthorToBook
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
            this.data_Books = new System.Windows.Forms.DataGridView();
            this.data_Author = new System.Windows.Forms.DataGridView();
            this.btn_AddAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Author)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Books
            // 
            this.data_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Books.Location = new System.Drawing.Point(12, 12);
            this.data_Books.Name = "data_Books";
            this.data_Books.Size = new System.Drawing.Size(484, 196);
            this.data_Books.TabIndex = 0;
            // 
            // data_Author
            // 
            this.data_Author.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Author.Location = new System.Drawing.Point(12, 214);
            this.data_Author.Name = "data_Author";
            this.data_Author.Size = new System.Drawing.Size(484, 196);
            this.data_Author.TabIndex = 1;
            // 
            // btn_AddAuthor
            // 
            this.btn_AddAuthor.Location = new System.Drawing.Point(502, 12);
            this.btn_AddAuthor.Name = "btn_AddAuthor";
            this.btn_AddAuthor.Size = new System.Drawing.Size(134, 67);
            this.btn_AddAuthor.TabIndex = 2;
            this.btn_AddAuthor.Text = "Ekle";
            this.btn_AddAuthor.UseVisualStyleBackColor = true;
            this.btn_AddAuthor.Click += new System.EventHandler(this.Btn_AddAuthor_Click);
            // 
            // Screen_AddAuthorToBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 415);
            this.Controls.Add(this.btn_AddAuthor);
            this.Controls.Add(this.data_Author);
            this.Controls.Add(this.data_Books);
            this.Name = "Screen_AddAuthorToBook";
            this.Text = "Kitaba Yazar Ekle";
            this.Load += new System.EventHandler(this.Screen_AddAuthorToBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Author)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_Books;
        private System.Windows.Forms.DataGridView data_Author;
        private System.Windows.Forms.Button btn_AddAuthor;
    }
}