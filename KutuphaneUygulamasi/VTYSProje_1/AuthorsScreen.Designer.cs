namespace VTYSProje_1
{
    partial class Screen_Authors
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
            this.btn_SearchAuthor = new System.Windows.Forms.Button();
            this.btn_DeleteAuthor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.btn_AddAuthor = new System.Windows.Forms.Button();
            this.data_AuthorsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_AuthorsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(547, 232);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(194, 53);
            this.btn_Refresh.TabIndex = 28;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_SearchAuthor
            // 
            this.btn_SearchAuthor.Location = new System.Drawing.Point(547, 55);
            this.btn_SearchAuthor.Name = "btn_SearchAuthor";
            this.btn_SearchAuthor.Size = new System.Drawing.Size(194, 53);
            this.btn_SearchAuthor.TabIndex = 27;
            this.btn_SearchAuthor.Text = "Ara";
            this.btn_SearchAuthor.UseVisualStyleBackColor = true;
            this.btn_SearchAuthor.Click += new System.EventHandler(this.Btn_SearchAuthor_Click);
            // 
            // btn_DeleteAuthor
            // 
            this.btn_DeleteAuthor.Location = new System.Drawing.Point(547, 173);
            this.btn_DeleteAuthor.Name = "btn_DeleteAuthor";
            this.btn_DeleteAuthor.Size = new System.Drawing.Size(194, 53);
            this.btn_DeleteAuthor.TabIndex = 26;
            this.btn_DeleteAuthor.Text = "Sil";
            this.btn_DeleteAuthor.UseVisualStyleBackColor = true;
            this.btn_DeleteAuthor.Click += new System.EventHandler(this.Btn_DeleteAuthor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Yazar Adı :";
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(613, 12);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(128, 20);
            this.txt_Author.TabIndex = 24;
            // 
            // btn_AddAuthor
            // 
            this.btn_AddAuthor.Location = new System.Drawing.Point(547, 114);
            this.btn_AddAuthor.Name = "btn_AddAuthor";
            this.btn_AddAuthor.Size = new System.Drawing.Size(194, 53);
            this.btn_AddAuthor.TabIndex = 23;
            this.btn_AddAuthor.Text = "Ekle";
            this.btn_AddAuthor.UseVisualStyleBackColor = true;
            this.btn_AddAuthor.Click += new System.EventHandler(this.Btn_AddAuthor_Click);
            // 
            // data_AuthorsList
            // 
            this.data_AuthorsList.AllowUserToAddRows = false;
            this.data_AuthorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_AuthorsList.Location = new System.Drawing.Point(12, 12);
            this.data_AuthorsList.Name = "data_AuthorsList";
            this.data_AuthorsList.ReadOnly = true;
            this.data_AuthorsList.Size = new System.Drawing.Size(526, 273);
            this.data_AuthorsList.TabIndex = 22;
            // 
            // Screen_Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 298);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_SearchAuthor);
            this.Controls.Add(this.btn_DeleteAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Author);
            this.Controls.Add(this.btn_AddAuthor);
            this.Controls.Add(this.data_AuthorsList);
            this.Name = "Screen_Authors";
            this.Text = "Yazarlar";
            this.Load += new System.EventHandler(this.Screen_Authors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_AuthorsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_SearchAuthor;
        private System.Windows.Forms.Button btn_DeleteAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Button btn_AddAuthor;
        private System.Windows.Forms.DataGridView data_AuthorsList;
    }
}