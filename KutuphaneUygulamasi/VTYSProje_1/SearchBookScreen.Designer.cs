namespace VTYSProje_1
{
    partial class Screen_SearchBook
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
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_BookList = new System.Windows.Forms.DataGridView();
            this.btn_SearchBook = new System.Windows.Forms.Button();
            this.btn_ReserveBook = new System.Windows.Forms.Button();
            this.btn_LeaveBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_BookList)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(79, 21);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(249, 20);
            this.txt_BookName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap İsmi : ";
            // 
            // data_BookList
            // 
            this.data_BookList.AllowUserToAddRows = false;
            this.data_BookList.AllowUserToDeleteRows = false;
            this.data_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_BookList.Location = new System.Drawing.Point(15, 54);
            this.data_BookList.Name = "data_BookList";
            this.data_BookList.ReadOnly = true;
            this.data_BookList.Size = new System.Drawing.Size(628, 253);
            this.data_BookList.TabIndex = 2;
            // 
            // btn_SearchBook
            // 
            this.btn_SearchBook.Location = new System.Drawing.Point(334, 12);
            this.btn_SearchBook.Name = "btn_SearchBook";
            this.btn_SearchBook.Size = new System.Drawing.Size(99, 36);
            this.btn_SearchBook.TabIndex = 3;
            this.btn_SearchBook.Text = "Ara";
            this.btn_SearchBook.UseVisualStyleBackColor = true;
            this.btn_SearchBook.Click += new System.EventHandler(this.Btn_SearchBook_Click);
            // 
            // btn_ReserveBook
            // 
            this.btn_ReserveBook.Location = new System.Drawing.Point(439, 12);
            this.btn_ReserveBook.Name = "btn_ReserveBook";
            this.btn_ReserveBook.Size = new System.Drawing.Size(99, 36);
            this.btn_ReserveBook.TabIndex = 4;
            this.btn_ReserveBook.Text = "Kitap Al";
            this.btn_ReserveBook.UseVisualStyleBackColor = true;
            this.btn_ReserveBook.Click += new System.EventHandler(this.Btn_ReserveBook_Click);
            // 
            // btn_LeaveBook
            // 
            this.btn_LeaveBook.Location = new System.Drawing.Point(544, 12);
            this.btn_LeaveBook.Name = "btn_LeaveBook";
            this.btn_LeaveBook.Size = new System.Drawing.Size(99, 36);
            this.btn_LeaveBook.TabIndex = 5;
            this.btn_LeaveBook.Text = "Kitap Bırak";
            this.btn_LeaveBook.UseVisualStyleBackColor = true;
            this.btn_LeaveBook.Click += new System.EventHandler(this.Btn_LeaveBook_Click);
            // 
            // Screen_SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 319);
            this.Controls.Add(this.btn_LeaveBook);
            this.Controls.Add(this.btn_ReserveBook);
            this.Controls.Add(this.btn_SearchBook);
            this.Controls.Add(this.data_BookList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BookName);
            this.Name = "Screen_SearchBook";
            this.Text = "Kitap Ara";
            this.Load += new System.EventHandler(this.Screen_SearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_BookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_BookList;
        private System.Windows.Forms.Button btn_SearchBook;
        private System.Windows.Forms.Button btn_ReserveBook;
        private System.Windows.Forms.Button btn_LeaveBook;
    }
}