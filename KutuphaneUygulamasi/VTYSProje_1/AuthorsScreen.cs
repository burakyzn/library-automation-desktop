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
    public partial class Screen_Authors : Form
    {

        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_Authors()
        {
            InitializeComponent();
        }

        private void Screen_Authors_Load(object sender, EventArgs e)
        {
            getDataFromAuthors();
        }

        public void getDataFromAuthors()
        {
            string selectLang = "SELECT AuthorNo AS YazarNo, AuthorName AS YazarAdı, PhoneNo AS TelefonNo, Email AS EPosta, isActive AS Aktiflik FROM Authors";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLang, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Authors");
            data_AuthorsList.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }

        private void Btn_AddAuthor_Click(object sender, EventArgs e)
        {
            Screen_AddAuthor AddAuthorScreen = new Screen_AddAuthor();
            AddAuthorScreen.Show();
            getDataFromAuthors();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            getDataFromAuthors();
        }

        private void Btn_DeleteAuthor_Click(object sender, EventArgs e)
        {
            string delete_AuthorName = Interaction.InputBox("Silinecek kitabın numarasını girin", "Kitap Sil");

            if (delete_AuthorName != String.Empty)
            {
                SqlConnection _connection = new SqlConnection(connectionString);
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("DeleteAuthor", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_authorNo", SqlDbType.Int).Value = delete_AuthorName;

                _connection.Open();
                int _error = _dataAdapter.SelectCommand.ExecuteNonQuery();
                _connection.Close();

                if (_error == 0)
                    MessageBox.Show("Kayıt yok veya silinemedi.");
                else
                    getDataFromAuthors();
            }

            getDataFromAuthors();
        }

        private void Btn_SearchAuthor_Click(object sender, EventArgs e)
        {
            string selectAuthor = "SELECT AuthorNo AS YazarNo, AuthorName AS YazarAdı, PhoneNo AS TelefonNo, Email AS EPosta, isActive AS Aktiflik FROM Authors WHERE AuthorName LIKE '%" + txt_Author.Text + "%'";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectAuthor, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Authors");
            data_AuthorsList.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }
    }
}
