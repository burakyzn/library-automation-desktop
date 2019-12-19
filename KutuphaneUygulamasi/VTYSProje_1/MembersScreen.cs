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
using Microsoft.VisualBasic;

namespace VTYSProje_1
{
    public partial class Screen_Members : Form
    {

        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_Members()
        {
            InitializeComponent();
        }

        private void Screen_Members_Load(object sender, EventArgs e)
        {
            getStudentFromDB();
            getStaffFromDB();
        }

        public void getStudentFromDB()
        {
            using (_connection = new SqlConnection(connectionString))
            {
                using (_dataAdapter = new SqlDataAdapter())
                {
                    _dataAdapter.SelectCommand = new SqlCommand("SelectStudent", _connection);
                    _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    _dataSet = new DataSet();
                    _dataAdapter.Fill(_dataSet, "Students");
                    data_StudentList.DataSource = _dataSet.Tables[0];
                }
            }
        }

        public void getStaffFromDB()
        {
            using (_connection = new SqlConnection(connectionString))
            {
                using (_dataAdapter = new SqlDataAdapter())
                {
                    _dataAdapter.SelectCommand = new SqlCommand("SelectStaff", _connection);
                    _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    _dataSet = new DataSet();
                    _dataAdapter.Fill(_dataSet, "Staff");
                    data_StaffList.DataSource = _dataSet.Tables[0];
                }
            }
        }

        private void Btn_DeleteMember_Click(object sender, EventArgs e)
        {
            string delete_memberNo = Interaction.InputBox("Silinecek kullanıcının numarasını girin ", "Kullanıcı Sil");

            if (delete_memberNo != String.Empty)
            {
                SqlConnection _connection = new SqlConnection(connectionString);
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("UpdateMember", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_operation", SqlDbType.Char).Value = 'D';
                _dataAdapter.SelectCommand.Parameters.Add("@_memberNo", SqlDbType.Int).Value = delete_memberNo;

                _connection.Open();
                int _error = _dataAdapter.SelectCommand.ExecuteNonQuery();
                _connection.Close();

                if (_error == 0)
                    MessageBox.Show("Kayıt yok veya silinemedi.");
                else
                {
                    getStudentFromDB();
                    getStaffFromDB();
                }
            }
        }

        private void Btn_SetAdmin_Click(object sender, EventArgs e)
        {
            string update_memberNo = Interaction.InputBox("Admin yapilacak kullanicinin numarasini girin", "Admin Yap");

            if (update_memberNo != String.Empty)
            {
                SqlConnection _connection = new SqlConnection(connectionString);
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("UpdateMember", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_operation", SqlDbType.Char).Value = 'U';
                _dataAdapter.SelectCommand.Parameters.Add("@_memberNo", SqlDbType.Int).Value = update_memberNo;

                _connection.Open();
                int _error = _dataAdapter.SelectCommand.ExecuteNonQuery();
                _connection.Close();

                if (_error == 0)
                    MessageBox.Show("Kayıt yok veya güncellenemedi.");
                else{
                    getStaffFromDB();
                    getStudentFromDB();
                }
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            getStudentFromDB();
            getStaffFromDB();
        }

        private void Btn_SearchMember_Click(object sender, EventArgs e)
        {
            //string selectMembers = "SELECT memberNo AS KullanıcıNo, nickName AS KullanıcıAdı, firstName AS Isim, lastName AS Soyisim, _password AS Sifre, email AS EPosta,RegisterTypes.RegisterTypeDesc AS KayıtTuru,isAdmin AS Adminlik, isActive AS Aktiflik  FROM Members INNER JOIN RegisterTypes ON RegisterTypes.registerTypeNo = Members.registerTypeNo WHERE nickName LIKE '%" + txt_Member.Text + "%'";

            //_connection = new SqlConnection(connectionString);
            //_dataAdapter = new SqlDataAdapter(selectMembers, _connection);
            //_dataSet = new DataSet();

            //_connection.Open();
            //_dataAdapter.Fill(_dataSet, "Members");
            //data_StudentList.DataSource = _dataSet.Tables[0];

            //_connection.Close();
        }
    }
}
