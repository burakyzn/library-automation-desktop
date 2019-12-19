namespace VTYSProje_1
{
    partial class Screen_Publisher
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
            this.btn_SearchPublisher = new System.Windows.Forms.Button();
            this.btn_DeletePublisher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.btn_AddPublisher = new System.Windows.Forms.Button();
            this.data_LangList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_LangList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(505, 232);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(194, 53);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_SearchPublisher
            // 
            this.btn_SearchPublisher.Location = new System.Drawing.Point(505, 55);
            this.btn_SearchPublisher.Name = "btn_SearchPublisher";
            this.btn_SearchPublisher.Size = new System.Drawing.Size(194, 53);
            this.btn_SearchPublisher.TabIndex = 13;
            this.btn_SearchPublisher.Text = "Ara";
            this.btn_SearchPublisher.UseVisualStyleBackColor = true;
            this.btn_SearchPublisher.Click += new System.EventHandler(this.Btn_SearchLang_Click);
            // 
            // btn_DeletePublisher
            // 
            this.btn_DeletePublisher.Location = new System.Drawing.Point(505, 173);
            this.btn_DeletePublisher.Name = "btn_DeletePublisher";
            this.btn_DeletePublisher.Size = new System.Drawing.Size(194, 53);
            this.btn_DeletePublisher.TabIndex = 12;
            this.btn_DeletePublisher.Text = "Sil";
            this.btn_DeletePublisher.UseVisualStyleBackColor = true;
            this.btn_DeletePublisher.Click += new System.EventHandler(this.Btn_DeletePublisher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yayınevi :";
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Location = new System.Drawing.Point(558, 9);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(138, 20);
            this.txt_Publisher.TabIndex = 10;
            // 
            // btn_AddPublisher
            // 
            this.btn_AddPublisher.Location = new System.Drawing.Point(505, 114);
            this.btn_AddPublisher.Name = "btn_AddPublisher";
            this.btn_AddPublisher.Size = new System.Drawing.Size(194, 53);
            this.btn_AddPublisher.TabIndex = 9;
            this.btn_AddPublisher.Text = "Ekle";
            this.btn_AddPublisher.UseVisualStyleBackColor = true;
            this.btn_AddPublisher.Click += new System.EventHandler(this.Btn_AddPublisher_Click);
            // 
            // data_LangList
            // 
            this.data_LangList.AllowUserToAddRows = false;
            this.data_LangList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_LangList.Location = new System.Drawing.Point(12, 12);
            this.data_LangList.Name = "data_LangList";
            this.data_LangList.ReadOnly = true;
            this.data_LangList.Size = new System.Drawing.Size(484, 273);
            this.data_LangList.TabIndex = 8;
            // 
            // Screen_Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 296);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_SearchPublisher);
            this.Controls.Add(this.btn_DeletePublisher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Publisher);
            this.Controls.Add(this.btn_AddPublisher);
            this.Controls.Add(this.data_LangList);
            this.Name = "Screen_Publisher";
            this.Text = "Yayınevleri";
            this.Load += new System.EventHandler(this.Screen_Publisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_LangList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_SearchPublisher;
        private System.Windows.Forms.Button btn_DeletePublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.Button btn_AddPublisher;
        private System.Windows.Forms.DataGridView data_LangList;
    }
}