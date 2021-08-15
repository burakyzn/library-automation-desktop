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
    public partial class Screen_Languages : Form
    {

        SqlConnection _connection;
        SqlDataAdapter _dataAdapter;
        DataSet _dataSet;
        string connectionString = "server=.; Initial Catalog=kutuphaneDB;Integrated Security=SSPI";

        public Screen_Languages()
        {
            InitializeComponent();
        }

        private void Screen_Languages_Load(object sender, EventArgs e)
        {
            getDataFromLang();
        }

        public void getDataFromLang()
        {
            string selectLang = "SELECT LangNo AS DilNo, LangName AS DilAdı, isActive AS Aktiflik FROM Languages";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLang, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Languages");
            data_LangList.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }

        private void Btn_SearchLang_Click(object sender, EventArgs e)
        {
            string selectLangWithWord = "SELECT LangNo AS DilNo, LangName AS DilAdı, isActive AS Aktiflik FROM Languages LIKE '%" + txt_Lang.Text + "%'";

            _connection = new SqlConnection(connectionString);
            _dataAdapter = new SqlDataAdapter(selectLangWithWord, _connection);
            _dataSet = new DataSet();

            _connection.Open();
            _dataAdapter.Fill(_dataSet, "Languages");
            data_LangList.DataSource = _dataSet.Tables[0];

            _connection.Close();
        }

        private void Btn_AddLang_Click(object sender, EventArgs e)
        {
            string add_LangNo = Interaction.InputBox("Eklenecek dili giriniz", "Dil Ekle");

            if (add_LangNo != String.Empty) {
                _connection = new SqlConnection(connectionString);
                _dataAdapter = new SqlDataAdapter("AddLang", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_langName", SqlDbType.NVarChar, (50)).Value = add_LangNo;


                _connection.Open();
                int _error = _dataAdapter.SelectCommand.ExecuteNonQuery();
                _connection.Close();

                if (_error == 0)
                    MessageBox.Show("Kayıt eklenemedi.");
                else
                    getDataFromLang();
            }
            
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            getDataFromLang();
        }

        private void Btn_DeleteLang_Click(object sender, EventArgs e)
        {
            string delete_langNo = Interaction.InputBox("Silinecek dilin numarasını girin", "Dil Sil");

            if(delete_langNo != String.Empty)
            {
                SqlConnection _connection = new SqlConnection(connectionString);
                SqlDataAdapter _dataAdapter = new SqlDataAdapter("DeleteLang", _connection);

                _dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _dataAdapter.SelectCommand.Parameters.Add("@_langNo", SqlDbType.Int).Value = delete_langNo;

                _connection.Open();
                int _error = _dataAdapter.SelectCommand.ExecuteNonQuery();
                _connection.Close();

                if (_error == 0)
                    MessageBox.Show("Kayıt yok veya silinemedi.");
                else
                    getDataFromLang();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Lang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_LangList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
