using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Screen_Admin : Form
    {
        public Screen_Admin()
        {
            InitializeComponent();
        }

        private void Btn_Languages_Click(object sender, EventArgs e)
        {
            Screen_Languages LanguagesScreen = new Screen_Languages();
            LanguagesScreen.Show();
        }

        private void Btn_Publishers_Click(object sender, EventArgs e)
        {
            Screen_Publisher PublishersScreen = new Screen_Publisher();
            PublishersScreen.Show();
        }

        private void Btn_Books_Click(object sender, EventArgs e)
        {
            Screen_Books BooksScreen = new Screen_Books();
            BooksScreen.Show();
        }

        private void Btn_Members_Click(object sender, EventArgs e)
        {
            Screen_Members MembersScreen = new Screen_Members();
            MembersScreen.Show();
        }

        private void Btn_Authors_Click(object sender, EventArgs e)
        {
            Screen_Authors AuthorsScreen = new Screen_Authors();
            AuthorsScreen.Show();
        }

        private void Btn_DonatedBooks_Click(object sender, EventArgs e)
        {
            Screen_DonatedBooks DonatedBooksScreen = new Screen_DonatedBooks();
            DonatedBooksScreen.Show();
        }

        private void Btn_Informations_Click(object sender, EventArgs e)
        {
            Screen_Information InformationScreen = new Screen_Information();
            InformationScreen.Show();
        }

        private void Btn_Categories_Click(object sender, EventArgs e)
        {
            Screen_Category CategoryScreen = new Screen_Category();
            CategoryScreen.Show();
        }
    }

}
