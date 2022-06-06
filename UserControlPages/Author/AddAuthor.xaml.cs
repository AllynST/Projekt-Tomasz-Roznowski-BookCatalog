using Projekt_Tomasz_Roznowski_BookCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Author
{
    /// <summary>
    /// Logika interakcji dla klasy AddAuthor.xaml
    /// </summary>
    public partial class AddAuthor : Window
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void AddAuthorBTN_Click(object sender, RoutedEventArgs e)
        {

            Models.Author author = new()
            {
                Name = AuthorName.Text,
                Surname = AuthorSurname.Text,
                DateOfBirth = DateTime.Parse(AuthorDate.Text),
                Description = AuthorDesc.Text


            };            

            

            AuthorRepository.AddAuthor(author);

            MessageBox.Show("Author Added");

            Application.Current.Windows[2].Close();

            Content = new BooksPage();


        }
    }
}
