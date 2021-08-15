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
    public partial class Screen_Information : Form
    {

        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_Information()
        {
            InitializeComponent();
        }

        private void Screen_Information_Load(object sender, EventArgs e)
        {
            getAllDataFromDB();
        }

        private void getAllDataFromDB()
        {
            using (_connection = new SqlConnection(connectionString))
            {
                using (_dataAdapter = new SqlDataAdapter())
                {
                    _connection.Open();
                    SqlDataAdapter _dataAdapter = new SqlDataAdapter("GetLibraryInformation", _connection);
                    _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter getBookCount = new SqlParameter();
                    SqlParameter getDonatedBookCount = new SqlParameter();
                    SqlParameter getPublisherCount = new SqlParameter();
                    SqlParameter getCategoryCount = new SqlParameter();
                    SqlParameter getLanguageCount = new SqlParameter();
                    SqlParameter getMemberCount = new SqlParameter();
                    SqlParameter getNeededBookCount = new SqlParameter();
                    SqlParameter getAuthorCount = new SqlParameter();

                    getBookCount.ParameterName = "@_BookCount";
                    getBookCount.SqlDbType = SqlDbType.Int;
                    getBookCount.Direction = ParameterDirection.Output;

                    getDonatedBookCount.ParameterName = "@_DonatedBookCount";
                    getDonatedBookCount.SqlDbType = SqlDbType.Int;
                    getDonatedBookCount.Direction = ParameterDirection.Output;

                    getPublisherCount.ParameterName = "@_PublisherCount";
                    getPublisherCount.SqlDbType = SqlDbType.Int;
                    getPublisherCount.Direction = ParameterDirection.Output;

                    getCategoryCount.ParameterName = "@_CategoryCount";
                    getCategoryCount.SqlDbType = SqlDbType.Int;
                    getCategoryCount.Direction = ParameterDirection.Output;

                    getLanguageCount.ParameterName = "@_LanguageCount";
                    getLanguageCount.SqlDbType = SqlDbType.Int;
                    getLanguageCount.Direction = ParameterDirection.Output;

                    getMemberCount.ParameterName = "@_MemberCount";
                    getMemberCount.SqlDbType = SqlDbType.Int;
                    getMemberCount.Direction = ParameterDirection.Output;

                    getNeededBookCount.ParameterName = "@_NeededBookCount";
                    getNeededBookCount.SqlDbType = SqlDbType.Int;
                    getNeededBookCount.Direction = ParameterDirection.Output;

                    getAuthorCount.ParameterName = "@_AuthorCount";
                    getAuthorCount.SqlDbType = SqlDbType.Int;
                    getAuthorCount.Direction = ParameterDirection.Output;

                    _dataAdapter.SelectCommand.Parameters.Add(getBookCount);
                    _dataAdapter.SelectCommand.Parameters.Add(getDonatedBookCount);
                    _dataAdapter.SelectCommand.Parameters.Add(getPublisherCount);
                    _dataAdapter.SelectCommand.Parameters.Add(getCategoryCount);
                    _dataAdapter.SelectCommand.Parameters.Add(getLanguageCount);
                    _dataAdapter.SelectCommand.Parameters.Add(getMemberCount);
                    _dataAdapter.SelectCommand.Parameters.Add(getNeededBookCount);
                    _dataAdapter.SelectCommand.Parameters.Add(getAuthorCount);
                    int a = _dataAdapter.SelectCommand.ExecuteNonQuery();

                    lbl_BookCount.Text = getBookCount.Value.ToString();
                    lbl_DonatedBookCount.Text = getDonatedBookCount.Value.ToString();
                    lbl_PublisherCount.Text = getPublisherCount.Value.ToString();
                    lbl_CategoryCount.Text = getCategoryCount.Value.ToString();
                    lbl_LanguageCount.Text = getLanguageCount.Value.ToString();
                    lbl_MemberCount.Text = getMemberCount.Value.ToString();
                    lbl_NeededBookCount.Text = getNeededBookCount.Value.ToString();
                    lbl_AuthorCount.Text = getAuthorCount.Value.ToString();

                    _connection.Close();
                }
            }
            
        }
    }
}
