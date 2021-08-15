namespace LibraryAutomation
{
    partial class Screen_DonatedBooks
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
            this.data_DonatedBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_DonatedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // data_DonatedBooks
            // 
            this.data_DonatedBooks.AllowUserToAddRows = false;
            this.data_DonatedBooks.AllowUserToDeleteRows = false;
            this.data_DonatedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DonatedBooks.Location = new System.Drawing.Point(12, 12);
            this.data_DonatedBooks.Name = "data_DonatedBooks";
            this.data_DonatedBooks.ReadOnly = true;
            this.data_DonatedBooks.Size = new System.Drawing.Size(256, 336);
            this.data_DonatedBooks.TabIndex = 0;
            // 
            // Screen_DonatedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 360);
            this.Controls.Add(this.data_DonatedBooks);
            this.Name = "Screen_DonatedBooks";
            this.Text = "Bağışlanan Kitaplar";
            this.Load += new System.EventHandler(this.Screen_DonatedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_DonatedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_DonatedBooks;
    }
}