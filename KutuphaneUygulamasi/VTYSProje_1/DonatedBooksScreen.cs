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
    public partial class Screen_DonatedBooks : Form
    {
        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_DonatedBooks()
        {
            InitializeComponent();
        }

        private void Screen_DonatedBooks_Load(object sender, EventArgs e)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                using (_dataAdapter = new SqlDataAdapter())
                {
                    _dataAdapter.SelectCommand = new SqlCommand("SelectDonatedBooks", _connection);
                    _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    _dataSet = new DataSet();
                    _dataAdapter.Fill(_dataSet, "DonatedBooks");
                    data_DonatedBooks.DataSource = _dataSet.Tables[0];
                }
            }
        }
    }
}
