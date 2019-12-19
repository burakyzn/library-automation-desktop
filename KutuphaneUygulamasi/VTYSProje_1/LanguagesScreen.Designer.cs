namespace VTYSProje_1
{
    partial class Screen_Languages
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
            this.data_LangList = new System.Windows.Forms.DataGridView();
            this.btn_AddLang = new System.Windows.Forms.Button();
            this.txt_Lang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteLang = new System.Windows.Forms.Button();
            this.btn_SearchLang = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_LangList)).BeginInit();
            this.SuspendLayout();
            // 
            // data_LangList
            // 
            this.data_LangList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_LangList.Location = new System.Drawing.Point(12, 12);
            this.data_LangList.Name = "data_LangList";
            this.data_LangList.Size = new System.Drawing.Size(307, 273);
            this.data_LangList.TabIndex = 0;
            this.data_LangList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_LangList_CellContentClick);
            // 
            // btn_AddLang
            // 
            this.btn_AddLang.Location = new System.Drawing.Point(332, 114);
            this.btn_AddLang.Name = "btn_AddLang";
            this.btn_AddLang.Size = new System.Drawing.Size(194, 53);
            this.btn_AddLang.TabIndex = 1;
            this.btn_AddLang.Text = "Ekle";
            this.btn_AddLang.UseVisualStyleBackColor = true;
            this.btn_AddLang.Click += new System.EventHandler(this.Btn_AddLang_Click);
            // 
            // txt_Lang
            // 
            this.txt_Lang.Location = new System.Drawing.Point(360, 12);
            this.txt_Lang.Name = "txt_Lang";
            this.txt_Lang.Size = new System.Drawing.Size(166, 20);
            this.txt_Lang.TabIndex = 2;
            this.txt_Lang.TextChanged += new System.EventHandler(this.Txt_Lang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dil :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_DeleteLang
            // 
            this.btn_DeleteLang.Location = new System.Drawing.Point(332, 173);
            this.btn_DeleteLang.Name = "btn_DeleteLang";
            this.btn_DeleteLang.Size = new System.Drawing.Size(194, 53);
            this.btn_DeleteLang.TabIndex = 4;
            this.btn_DeleteLang.Text = "Sil";
            this.btn_DeleteLang.UseVisualStyleBackColor = true;
            this.btn_DeleteLang.Click += new System.EventHandler(this.Btn_DeleteLang_Click);
            // 
            // btn_SearchLang
            // 
            this.btn_SearchLang.Location = new System.Drawing.Point(332, 55);
            this.btn_SearchLang.Name = "btn_SearchLang";
            this.btn_SearchLang.Size = new System.Drawing.Size(194, 53);
            this.btn_SearchLang.TabIndex = 6;
            this.btn_SearchLang.Text = "Ara";
            this.btn_SearchLang.UseVisualStyleBackColor = true;
            this.btn_SearchLang.Click += new System.EventHandler(this.Btn_SearchLang_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(332, 232);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(194, 53);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Screen_Languages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 298);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_SearchLang);
            this.Controls.Add(this.btn_DeleteLang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Lang);
            this.Controls.Add(this.btn_AddLang);
            this.Controls.Add(this.data_LangList);
            this.Name = "Screen_Languages";
            this.Text = "Diller";
            this.Load += new System.EventHandler(this.Screen_Languages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_LangList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_LangList;
        private System.Windows.Forms.Button btn_AddLang;
        private System.Windows.Forms.TextBox txt_Lang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DeleteLang;
        private System.Windows.Forms.Button btn_SearchLang;
        private System.Windows.Forms.Button btn_Refresh;
    }
}