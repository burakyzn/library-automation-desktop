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
    public partial class Screen_Publisher : Form
    {
        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_Publisher()
        {
            InitializeComponent();
        }

        private void Screen_Publisher_Load(object sender, EventArgs e)
        {
            getDataFromPublishers();
        }

        public void getDataFromPublishers()
        {
            string selectLang = "SELECT PublisherNo AS YayıneviNo, PublisherName AS YayıneviAdı, PhoneNo AS TelefonNo, PublisherAddress AS Adres, Email AS EPosta, WebURL, isActive AS Aktiflik FROM Publishers";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLang, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Publishers");
            data_LangList.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }

        private void Btn_SearchLang_Click(object sender, EventArgs e)
        {
            string selectLangWithWord = "SELECT PublisherNo AS YayıneviNo, PublisherName AS YayıneviAdı, PhoneNo AS TelefonNo, PublisherAddress AS Adres, Email AS EPosta, WebURL, isActive AS Aktiflik FROM Publishers LIKE '%" + txt_Publisher.Text + "%'";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLangWithWord, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Publishers");
            data_LangList.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }

        private void Btn_AddPublisher_Click(object sender, EventArgs e)
        {
            Screen_AddPublisher AddPublisherScreen = new Screen_AddPublisher();
            AddPublisherScreen.Show();
            getDataFromPublishers();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            getDataFromPublishers();
        }

        private void Btn_DeletePublisher_Click(object sender, EventArgs e)
        {
            string delete_publisherNo = Interaction.InputBox("Silinecek yayınevinin numarasını girin", "Yayınevi Sil");

            if(delete_publisherNo != String.Empty)
            {
                SqlConnection _connection = new SqlConnection(connectionString);
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("DeletePublisher", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_publisherNo", SqlDbType.Int).Value = delete_publisherNo;

                _connection.Open();
                int _error = _dataAdapter.SelectCommand.ExecuteNonQuery();
                _connection.Close();

                if (_error == 0)
                    MessageBox.Show("Kayıt yok veya silinemedi.");
                else
                    getDataFromPublishers();
            }
        }
    }
}
