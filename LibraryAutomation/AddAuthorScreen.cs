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
    public partial class Screen_AddAuthor : Form
    {

        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_AddAuthor()
        {
            InitializeComponent();
        }

        private void Btn_AddAuthor_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter("AddAuthor", _connection);

            _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            _dataAdapter.SelectCommand.Parameters.Add("@_authorName", SqlDbType.NVarChar, (50)).Value = txt_Name.Text;
            _dataAdapter.SelectCommand.Parameters.Add("@_phoneNo", SqlDbType.NVarChar).Value = txt_PhoneNo.Text;
            _dataAdapter.SelectCommand.Parameters.Add("@_email", SqlDbType.NVarChar, (50)).Value = txt_Email.Text;

            _connection.Open();
            int _error = _dataAdapter.SelectCommand.ExecuteNonQuery();
            _connection.Close();

            if (_error == 0)
                MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
            else
            {
                MessageBox.Show("Kayıt başarıyla eklendi.");
                this.Close();
            }
        }
    }
}
