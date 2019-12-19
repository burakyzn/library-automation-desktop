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
    public partial class Screen_Register : Form
    {
        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_Register()
        { 
            InitializeComponent();
            ComboboxItem onLisans = new ComboboxItem("Önlisans", 1);
            ComboboxItem lisans = new ComboboxItem("Lisans", 2);
            ComboboxItem yuksekLisans = new ComboboxItem("Yüksek Lisans", 3);
            ComboboxItem doktora = new ComboboxItem("Doktora", 4);
            ComboboxItem akademik = new ComboboxItem("Akademik Personel", 5);
            ComboboxItem idari = new ComboboxItem("İdari Personel", 6);
            ComboboxItem erasmusfarabi = new ComboboxItem("Erasmus/Farabi", 7);

            cbox_alan.Items.Add(onLisans);
            cbox_alan.Items.Add(lisans);
            cbox_alan.Items.Add(yuksekLisans);
            cbox_alan.Items.Add(doktora);
            cbox_alan.Items.Add(akademik);
            cbox_alan.Items.Add(idari);
            cbox_alan.Items.Add(erasmusfarabi);
        }

        private void Btn_kayitOl_Click(object sender, EventArgs e)
        {
            using (_connection = new SqlConnection(connectionString))
            {
                _connection.Open();
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("AddStudent", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_nickname", SqlDbType.NVarChar, (15)).Value = txt_kullaniciAdi.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_firstName", SqlDbType.NVarChar, (15)).Value = txt_adi.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_lastName", SqlDbType.NVarChar, (15)).Value = txt_soyadi.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_pass", SqlDbType.NVarChar, (15)).Value = txt_sifre.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_email", SqlDbType.NVarChar, (15)).Value = txt_email.Text;
                _dataAdapter.SelectCommand.Parameters.Add("@_registerTypeNo", SqlDbType.Int).Value = (cbox_alan.SelectedItem as ComboboxItem).Value;

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

        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public ComboboxItem(string text, int value)
        {
            this.Text = text;
            this.Value = value;
        }
    }
}
