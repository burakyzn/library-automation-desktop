namespace VTYSProje_1
{
    partial class Screen_Members
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
            this.btn_SearchMember = new System.Windows.Forms.Button();
            this.btn_DeleteMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Member = new System.Windows.Forms.TextBox();
            this.btn_SetAdmin = new System.Windows.Forms.Button();
            this.data_StudentList = new System.Windows.Forms.DataGridView();
            this.data_StaffList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_StaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(547, 232);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(194, 53);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_SearchMember
            // 
            this.btn_SearchMember.Location = new System.Drawing.Point(547, 55);
            this.btn_SearchMember.Name = "btn_SearchMember";
            this.btn_SearchMember.Size = new System.Drawing.Size(194, 53);
            this.btn_SearchMember.TabIndex = 20;
            this.btn_SearchMember.Text = "Ara";
            this.btn_SearchMember.UseVisualStyleBackColor = true;
            this.btn_SearchMember.Click += new System.EventHandler(this.Btn_SearchMember_Click);
            // 
            // btn_DeleteMember
            // 
            this.btn_DeleteMember.Location = new System.Drawing.Point(547, 173);
            this.btn_DeleteMember.Name = "btn_DeleteMember";
            this.btn_DeleteMember.Size = new System.Drawing.Size(194, 53);
            this.btn_DeleteMember.TabIndex = 19;
            this.btn_DeleteMember.Text = "Sil";
            this.btn_DeleteMember.UseVisualStyleBackColor = true;
            this.btn_DeleteMember.Click += new System.EventHandler(this.Btn_DeleteMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kullanıcılar :";
            // 
            // txt_Member
            // 
            this.txt_Member.Location = new System.Drawing.Point(613, 12);
            this.txt_Member.Name = "txt_Member";
            this.txt_Member.Size = new System.Drawing.Size(128, 20);
            this.txt_Member.TabIndex = 17;
            // 
            // btn_SetAdmin
            // 
            this.btn_SetAdmin.Location = new System.Drawing.Point(547, 114);
            this.btn_SetAdmin.Name = "btn_SetAdmin";
            this.btn_SetAdmin.Size = new System.Drawing.Size(194, 53);
            this.btn_SetAdmin.TabIndex = 16;
            this.btn_SetAdmin.Text = "Admin Yap";
            this.btn_SetAdmin.UseVisualStyleBackColor = true;
            this.btn_SetAdmin.Click += new System.EventHandler(this.Btn_SetAdmin_Click);
            // 
            // data_StudentList
            // 
            this.data_StudentList.AllowUserToAddRows = false;
            this.data_StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_StudentList.Location = new System.Drawing.Point(12, 12);
            this.data_StudentList.Name = "data_StudentList";
            this.data_StudentList.ReadOnly = true;
            this.data_StudentList.Size = new System.Drawing.Size(526, 191);
            this.data_StudentList.TabIndex = 15;
            // 
            // data_StaffList
            // 
            this.data_StaffList.AllowUserToAddRows = false;
            this.data_StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_StaffList.Location = new System.Drawing.Point(12, 209);
            this.data_StaffList.Name = "data_StaffList";
            this.data_StaffList.ReadOnly = true;
            this.data_StaffList.Size = new System.Drawing.Size(526, 191);
            this.data_StaffList.TabIndex = 22;
            // 
            // Screen_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 405);
            this.Controls.Add(this.data_StaffList);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_SearchMember);
            this.Controls.Add(this.btn_DeleteMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Member);
            this.Controls.Add(this.btn_SetAdmin);
            this.Controls.Add(this.data_StudentList);
            this.Name = "Screen_Members";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Screen_Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_StaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_SearchMember;
        private System.Windows.Forms.Button btn_DeleteMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Member;
        private System.Windows.Forms.Button btn_SetAdmin;
        private System.Windows.Forms.DataGridView data_StudentList;
        private System.Windows.Forms.DataGridView data_StaffList;
    }
}