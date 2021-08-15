using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Screen_Home : Form
    {
        Member AuthPerson = new Member();

        public Screen_Home()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            btn_AdminPanel.Visible = false;
            if(AuthPerson.Auth == false)
            {
                Screen_Login _Screen_Login = new Screen_Login(AuthPerson,this);
                this.Opacity = 0;
                _Screen_Login.Show();
            }
        }

        private void Btn_SearchBook_Click(object sender, EventArgs e)
        {
            Screen_SearchBook SearchBookScreen = new Screen_SearchBook(AuthPerson);
            SearchBookScreen.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(AuthPerson.Id != "")
            {
                lbl_MemberNo.Text = AuthPerson.Id;
                lbl_MemberNick.Text = AuthPerson.NickName;


                if (AuthPerson.isAdmin == "True")
                {
                    btn_AdminPanel.Visible = true;
                }
                timer1.Enabled = false;
            }
        }

        private void Btn_AdminPanel_Click(object sender, EventArgs e)
        {
            Screen_Admin AdminScreen = new Screen_Admin();
            AdminScreen.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Screen_AddBook AddBookScreen = new Screen_AddBook(AuthPerson);
            AddBookScreen.Show();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Member
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        public bool Auth { get; set; }
        public string isAdmin { get; set; }

        public Member() {
            this.Id = "";
            this.NickName = "";
            this.Auth = false;
            this.isAdmin = "0";    
        }

        public Member(string _id, string _nickName)
        {
            this.Id = _id;
            this.NickName = _nickName;
            this.Auth = false;
            this.isAdmin = "0";
        }
    };

}
