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
    public partial class Screen_SearchBook : Form
    {
        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        Member AuthPerson;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_SearchBook(Member _AuthPerson)
        {
            InitializeComponent();
            AuthPerson = _AuthPerson;
        }

        private void getDataFromBooks()
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

        private void Screen_SearchBook_Load(object sender, EventArgs e)
        {
            getDataFromBooks();
        }

        private void Btn_ReserveBook_Click(object sender, EventArgs e)
        {
            string res_Book = Interaction.InputBox("Alınacak kitabın numarasını giriniz", "Kitap Al");

            if(res_Book != String.Empty)
            {
                using (_connection = new SqlConnection(connectionString))
                {
                    using (_dataAdapter = new SqlDataAdapter())
                    {
                        _connection.Open();
                        SqlDataAdapter _dataAdapter = new SqlDataAdapter("BorrowBookFromLibrary", _connection);
                        SqlParameter errorOutputParameter = new SqlParameter();
                        _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        _dataAdapter.SelectCommand.Parameters.Add("@_BookNo", SqlDbType.Int).Value = Convert.ToInt32(res_Book);
                        _dataAdapter.SelectCommand.Parameters.Add("@_MemberNo", SqlDbType.Int).Value = Convert.ToInt32(AuthPerson.Id);

                        errorOutputParameter.ParameterName = "@_Message";
                        errorOutputParameter.SqlDbType = SqlDbType.NVarChar;
                        errorOutputParameter.Size = 200;
                        errorOutputParameter.Direction = ParameterDirection.Output;

                        _dataAdapter.SelectCommand.Parameters.Add(errorOutputParameter);
                        int a = _dataAdapter.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show(errorOutputParameter.Value.ToString());

                        _connection.Close();
                    }
                }
            }

            getDataFromBooks();
        }

        private void Btn_LeaveBook_Click(object sender, EventArgs e)
        {
            string leave_book = Interaction.InputBox("Alınacak kitabın numarasını giriniz", "Kitap Al");

            if (leave_book != String.Empty)
            {
                using (_connection = new SqlConnection(connectionString))
                {
                    using (_dataAdapter = new SqlDataAdapter())
                    {
                        _connection.Open();
                        SqlDataAdapter _dataAdapter = new SqlDataAdapter("LeaveBook", _connection);
                        SqlParameter errorOutputParameter = new SqlParameter();
                        _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        _dataAdapter.SelectCommand.Parameters.Add("@_BookNo", SqlDbType.Int).Value = Convert.ToInt32(leave_book);
                        _dataAdapter.SelectCommand.Parameters.Add("@_MemberNo", SqlDbType.Int).Value = Convert.ToInt32(AuthPerson.Id);

                        errorOutputParameter.ParameterName = "@_Message";
                        errorOutputParameter.SqlDbType = SqlDbType.NVarChar;
                        errorOutputParameter.Size = 200;
                        errorOutputParameter.Direction = ParameterDirection.Output;

                        _dataAdapter.SelectCommand.Parameters.Add(errorOutputParameter);
                        int a = _dataAdapter.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show(errorOutputParameter.Value.ToString());

                        _connection.Close();
                    }
                }
            }

            getDataFromBooks();
        }
    }
}
