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
    public partial class Screen_AddAuthorToBook : Form
    {
        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_AddAuthorToBook()
        {
            InitializeComponent();
        }

        private void Screen_AddAuthorToBook_Load(object sender, EventArgs e)
        {
            getDataFromBooks();
            getDataFromAuthors();
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
                    data_Books.DataSource = _dataSet.Tables[0];
                }
            }
        }

        private void getDataFromAuthors()
        {
            string selectLang = "SELECT * FROM Authors";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLang, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Authors");
            data_Author.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }

        private void Btn_AddAuthor_Click(object sender, EventArgs e)
        {
            string book = Interaction.InputBox("Kitabın numarasını giriniz", "Yazar Ekle");
            string author = Interaction.InputBox("Yazarın numarasını giriniz ", "Yazar Ekle");

            if (book != String.Empty || author != String.Empty)
            {
                using (_connection = new SqlConnection(connectionString))
                {
                    using (_dataAdapter = new SqlDataAdapter())
                    {
                        _connection.Open();
                        SqlDataAdapter _dataAdapter = new SqlDataAdapter("AddAuthorToBook", _connection);
                        SqlParameter errorOutputParameter = new SqlParameter();
                        _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        _dataAdapter.SelectCommand.Parameters.Add("@_BookNo", SqlDbType.Int).Value = Convert.ToInt32(book);
                        _dataAdapter.SelectCommand.Parameters.Add("@_AuthorNo", SqlDbType.Int).Value = Convert.ToInt32(author);

                        errorOutputParameter.ParameterName = "@_Message";
                        errorOutputParameter.SqlDbType = SqlDbType.NVarChar;
                        errorOutputParameter.Size = 50;
                        errorOutputParameter.Direction = ParameterDirection.Output;

                        _dataAdapter.SelectCommand.Parameters.Add(errorOutputParameter);
                        int a = _dataAdapter.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show(errorOutputParameter.Value.ToString());

                        _connection.Close();
                    }
                }
            }

            getDataFromBooks();
            getDataFromAuthors();
        }
    }
}
