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
    public partial class Screen_AddPublisher : Form
    {

        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_AddPublisher()
        {
            InitializeComponent();
        }

        private void Btn_AddPublisher_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter("AddPublisher", _connection);

            _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            _dataAdapter.SelectCommand.Parameters.Add("@_publisherName", SqlDbType.NVarChar, (50)).Value = txt_publisherName.Text;
            _dataAdapter.SelectCommand.Parameters.Add("@_phoneNo", SqlDbType.NVarChar, (50)).Value = txt_phoneNo.Text;
            _dataAdapter.SelectCommand.Parameters.Add("@_adress", SqlDbType.NVarChar, (50)).Value = txt_address.Text;
            _dataAdapter.SelectCommand.Parameters.Add("@_email", SqlDbType.NVarChar, (50)).Value = txt_email.Text;
            _dataAdapter.SelectCommand.Parameters.Add("@_webURL", SqlDbType.NVarChar, (50)).Value = txt_WebURL.Text;

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
