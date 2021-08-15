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

namespace LibraryAutomation
{
    public partial class Screen_Books : Form
    {
        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_Books()
        {
            InitializeComponent();
        }

        public void getDataFromBooks()
        {
            using (_connection = new SqlConnection(connectionString))
            {
                using (_dataAdapter = new SqlDataAdapter())
                {
                    _dataAdapter.SelectCommand = new SqlCommand("SelectBooksWithOtherTables", _connection);
                    _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    _dataSet = new DataSet();
                    _dataAdapter.Fill(_dataSet, "Books");
                    data_BookList.DataSource = _dataSet.Tables[0];
                }
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            getDataFromBooks();
        }

        private void Screen_Books_Load(object sender, EventArgs e)
        {
            getDataFromBooks();
        }

        private void Btn_AddBook_Click(object sender, EventArgs e)
        {
            Member fakeAuthPerson = new Member("-5","");
            Screen_AddBook AddBookScreen = new Screen_AddBook(fakeAuthPerson);
            AddBookScreen.Show();
        }

        private void Btn_SearchBook_Click(object sender, EventArgs e)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                using (_dataAdapter = new SqlDataAdapter())
                {
                    _dataAdapter.SelectCommand = new SqlCommand("SelectBooksWithWord", _connection);
                    _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    _dataAdapter.SelectCommand.Parameters.Add("@_BookName", SqlDbType.NVarChar, (50)).Value = txt_BookName.Text;

                    _dataSet = new DataSet();
                    _dataAdapter.Fill(_dataSet, "Books");
                    data_BookList.DataSource = _dataSet.Tables[0];
                }
            }
        }

        private void Btn_DeleteBook_Click(object sender, EventArgs e)
        {
            string delete_bookNo = Interaction.InputBox("Silinecek kitabın numarasını girin", "Kitap Sil");
            
            if(delete_bookNo != String.Empty)
            {
                SqlConnection _connection = new SqlConnection(connectionString);
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("DeleteBook", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_bookNo", SqlDbType.Int).Value = delete_bookNo;

                _connection.Open();
                int _error = _dataAdapter.SelectCommand.ExecuteNonQuery();
                _connection.Close();

                if (_error == 0)
                    MessageBox.Show("Kayıt yok veya silinemedi.");
                else
                    getDataFromBooks();
            }
        }

        private void Btn_AddAuthors_Click(object sender, EventArgs e)
        {
            Screen_AddAuthorToBook AddAuthorsToBook = new Screen_AddAuthorToBook();
            AddAuthorsToBook.Show();
        }
    }
}
