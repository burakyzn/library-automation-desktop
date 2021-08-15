using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryAutomation
{
    public partial class Screen_Login : Form
    {
        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;

        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        Form _ScreenHome;
        Member AuthPerson;

        public Screen_Login(Member _AuthPerson,Form _HomeScreen)
        {
            InitializeComponent();
            _ScreenHome = _HomeScreen;
            AuthPerson = _AuthPerson;
        }


        private void Btn_RegisterStaff_Click(object sender, EventArgs e)
        {
            Screen_RegisterStaff regStaff = new Screen_RegisterStaff();
            regStaff.Show();
        }

        private void Btn_RegisterStudent_Click(object sender, EventArgs e)
        {
            Screen_Register _registerScreen = new Screen_Register();
            _registerScreen.Show();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string selectMemberFromMember = "Select * From Members";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectMemberFromMember, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Members");

            for (int i = 0; i < _dataSet.Tables[0].Rows.Count; i++)
            {
                if (_dataSet.Tables[0].Rows[i][1].ToString() == txt_kullaniciAdi.Text
                                           && _dataSet.Tables[0].Rows[i][4].ToString() == txt_sifre.Text)
                {
                    AuthPerson.Id = _dataSet.Tables[0].Rows[i][0].ToString();
                    AuthPerson.NickName = _dataSet.Tables[0].Rows[i][1].ToString();
                    AuthPerson.Auth = true;
                    AuthPerson.isAdmin = _dataSet.Tables[0].Rows[i][6].ToString();
                    _ScreenHome.Opacity = 100;
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            _connection.Close();
        }
    }
}
