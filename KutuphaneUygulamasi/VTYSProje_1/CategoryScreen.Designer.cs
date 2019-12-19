namespace VTYSProje_1
{
    partial class Screen_Category
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
            this.btn_SearcCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.data_CategoryList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_CategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(332, 173);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(194, 53);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_SearcCategory
            // 
            this.btn_SearcCategory.Location = new System.Drawing.Point(332, 55);
            this.btn_SearcCategory.Name = "btn_SearcCategory";
            this.btn_SearcCategory.Size = new System.Drawing.Size(194, 53);
            this.btn_SearcCategory.TabIndex = 13;
            this.btn_SearcCategory.Text = "Ara";
            this.btn_SearcCategory.UseVisualStyleBackColor = true;
            this.btn_SearcCategory.Click += new System.EventHandler(this.Btn_SearcCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kategori :";
            // 
            // txt_Category
            // 
            this.txt_Category.Location = new System.Drawing.Point(387, 12);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(139, 20);
            this.txt_Category.TabIndex = 10;
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.Location = new System.Drawing.Point(332, 114);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(194, 53);
            this.btn_AddCategory.TabIndex = 9;
            this.btn_AddCategory.Text = "Ekle";
            this.btn_AddCategory.UseVisualStyleBackColor = true;
            this.btn_AddCategory.Click += new System.EventHandler(this.Btn_AddCategory_Click);
            // 
            // data_CategoryList
            // 
            this.data_CategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_CategoryList.Location = new System.Drawing.Point(12, 12);
            this.data_CategoryList.Name = "data_CategoryList";
            this.data_CategoryList.Size = new System.Drawing.Size(307, 214);
            this.data_CategoryList.TabIndex = 8;
            // 
            // Screen_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 239);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_SearcCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.data_CategoryList);
            this.Name = "Screen_Category";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Screen_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_CategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_SearcCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.DataGridView data_CategoryList;
    }
}