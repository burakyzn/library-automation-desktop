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
    public partial class Screen_RegisterStaff : Form
    {
        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_RegisterStaff()
        {
            InitializeComponent();
        }

        private void Btn_kayitOl_Click(object sender, EventArgs e)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("AddStaff", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_nickname", SqlDbType.NVarChar, (15)).Value = txt_NickName.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_firstName", SqlDbType.NVarChar, (15)).Value = txt_Name.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_lastName", SqlDbType.NVarChar, (15)).Value = txt_Surname.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_pass", SqlDbType.NVarChar, (15)).Value = txt_Pass.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_email", SqlDbType.NVarChar, (30)).Value = txt_Email.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_departmenDesc", SqlDbType.NVarChar, (20)).Value = txt_Departmant.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_titleDesc", SqlDbType.NVarChar, (20)).Value = txt_Title.Text;

                SqlParameter messageParameter = new SqlParameter();
                messageParameter.ParameterName = "@_Message";
                messageParameter.SqlDbType = SqlDbType.NVarChar;
                messageParameter.Size = 50;
                messageParameter.Direction = ParameterDirection.Output;
                _dataAdapter.SelectCommand.Parameters.Add(messageParameter);

                int a = _dataAdapter.SelectCommand.ExecuteNonQuery();

                MessageBox.Show(messageParameter.Value.ToString());

                _connection.Close();
                this.Close();
            }
        }
    }
}
