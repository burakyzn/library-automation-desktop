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

namespace VTYSProje_1
{
    public partial class Screen_AddBook : Form
    {

        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        Member AuthPerson;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_AddBook(Member _AuthPerson)
        {
            InitializeComponent();
            AuthPerson = _AuthPerson;
        }

        public void setPublisher()
        {
            string selectPublishers = "SELECT * FROM Publishers WHERE isActive = 1";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectPublishers, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Publishers");

            _connection.Close();

            for (int i = 0; i < _dataSet.Tables[0].Rows.Count; i++)
            {
                cbox_Publisher.Items.Add(new ComboboxItem(_dataSet.Tables[0].Rows[i][1].ToString(), Convert.ToInt32(_dataSet.Tables[0].Rows[i][0])));
            }
        }

        public void setLang()
        {
            string selectLang = "SELECT * FROM Languages WHERE isActive = 1";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLang, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Languages");

            _connection.Close();

            for (int i = 0; i < _dataSet.Tables[0].Rows.Count; i++)
            {
                cbox_Lang.Items.Add(new ComboboxItem(_dataSet.Tables[0].Rows[i][1].ToString(), Convert.ToInt32(_dataSet.Tables[0].Rows[i][0])));
            }
        }

        public void setCategories()
        {
            string selectLang = "SELECT * FROM Categories";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLang, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Categories");

            _connection.Close();

            for (int i = 0; i < _dataSet.Tables[0].Rows.Count; i++)
            {
                cbox_Category.Items.Add(new ComboboxItem(_dataSet.Tables[0].Rows[i][1].ToString(), Convert.ToInt32(_dataSet.Tables[0].Rows[i][0])));
            }
        }

        private void Screen_AddBook_Load(object sender, EventArgs e)
        {
            setPublisher();
            setLang();
            setCategories();
        }

        private void Btn_AddBook_Click(object sender, EventArgs e)
        {
    
           if(AuthPerson.Id == "-5")
            {
                _connection.Open();
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("AddBook", _connection);
                SqlParameter errorOutputParameter = new SqlParameter();
                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_ISBN", SqlDbType.NVarChar, (50)).Value = txt_ISBN.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_bookName", SqlDbType.NVarChar, (50)).Value = txt_BookName.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_publisherNo", SqlDbType.Int).Value = (cbox_Publisher.SelectedItem as ComboboxItem).Value;
                _dataAdapter.SelectCommand.Parameters.Add("@_categoryNo", SqlDbType.Int).Value = (cbox_Category.SelectedItem as ComboboxItem).Value;
                _dataAdapter.SelectCommand.Parameters.Add("@_pageCount", SqlDbType.NVarChar, (50)).Value = txt_PageCount.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_langNo", SqlDbType.Int).Value = (cbox_Lang.SelectedItem as ComboboxItem).Value;

                errorOutputParameter.ParameterName = "@_Message";
                errorOutputParameter.SqlDbType = SqlDbType.NVarChar;
                errorOutputParameter.Size = 50;
                errorOutputParameter.Direction = ParameterDirection.Output;

                _dataAdapter.SelectCommand.Parameters.Add(errorOutputParameter);
                int a = _dataAdapter.SelectCommand.ExecuteNonQuery();

                MessageBox.Show(errorOutputParameter.Value.ToString());

                _connection.Close();
                this.Close();
            }
           else
            {
                using (_connection = new SqlConnection(connectionString))
                {
                    using (_dataAdapter = new SqlDataAdapter())
                    {
                        _connection.Open();
                        SqlDataAdapter _dataAdapter = new SqlDataAdapter("AddBookFromDon", _connection);
                        SqlParameter errorOutputParameter = new SqlParameter();
                        _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        _dataAdapter.SelectCommand.Parameters.Add("@_ISBN", SqlDbType.NVarChar, (50)).Value = txt_ISBN.Text;
                        _dataAdapter.SelectCommand.Parameters.Add("@_bookName", SqlDbType.NVarChar, (50)).Value = txt_BookName.Text;
                        _dataAdapter.SelectCommand.Parameters.Add("@_publisherNo", SqlDbType.Int).Value = (cbox_Publisher.SelectedItem as ComboboxItem).Value;
                        _dataAdapter.SelectCommand.Parameters.Add("@_pageCount", SqlDbType.NVarChar, (50)).Value = txt_PageCount.Text;
                        _dataAdapter.SelectCommand.Parameters.Add("@_categoryNo", SqlDbType.Int).Value = (cbox_Category.SelectedItem as ComboboxItem).Value;
                        _dataAdapter.SelectCommand.Parameters.Add("@_langNo", SqlDbType.Int).Value = (cbox_Lang.SelectedItem as ComboboxItem).Value;
                        _dataAdapter.SelectCommand.Parameters.Add("@_DonMemberNo", SqlDbType.Int).Value = Convert.ToInt32(AuthPerson.Id);

                        errorOutputParameter.ParameterName = "@_Message";
                        errorOutputParameter.SqlDbType = SqlDbType.NVarChar;
                        errorOutputParameter.Size = 50;
                        errorOutputParameter.Direction = ParameterDirection.Output;

                        _dataAdapter.SelectCommand.Parameters.Add(errorOutputParameter);
                        int a = _dataAdapter.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show(errorOutputParameter.Value.ToString());

                        _connection.Close();
                        this.Close();
                    }
                }
            }
        }
    }
}
