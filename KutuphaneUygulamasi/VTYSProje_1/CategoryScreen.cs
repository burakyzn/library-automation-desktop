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
    public partial class Screen_Category : Form
    {

        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_Category()
        {
            InitializeComponent();
        }

        private void Screen_Category_Load(object sender, EventArgs e)
        {
            getCategoriesFromDB();
        }

        private void getCategoriesFromDB()
        {
            string selectLang = "SELECT CategoryNo AS KategoriNo, CategoryName AS KategoriAdı FROM Categories";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLang, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Categories");
            data_CategoryList.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }

        private void Btn_SearcCategory_Click(object sender, EventArgs e)
        {
            string selectLangWithWord = "SELECT CategoryNo AS KategoriNo, CategoryName AS KategoriAdı FROM Categories WHERE CategoryName LIKE '%" + txt_Category.Text + "%'";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLangWithWord, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Categories");
            data_CategoryList.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            getCategoriesFromDB();
        }

        private void Btn_AddCategory_Click(object sender, EventArgs e)
        {
            string add_category = Interaction.InputBox("Kategorinin adını girin", "Kategori Ekle");

            if (add_category != String.Empty)
            {
                using (_connection = new SqlConnection(connectionString))
                {
                    using (_dataAdapter = new SqlDataAdapter())
                    {
                        _connection.Open();
                        SqlDataAdapter _dataAdapter = new SqlDataAdapter("AddCategory", _connection);
                        SqlParameter errorOutputParameter = new SqlParameter();
                        _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        _dataAdapter.SelectCommand.Parameters.Add("@_CategoryName", SqlDbType.NVarChar).Value = add_category;

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

            getCategoriesFromDB();
        }
    }
}
