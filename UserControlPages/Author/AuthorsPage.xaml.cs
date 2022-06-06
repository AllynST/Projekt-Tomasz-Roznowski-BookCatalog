using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
using Projekt_Tomasz_Roznowski_BookCatalog.Services;
using Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Author;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt_Tomasz_Roznowski_BookCatalog
{

    /// <summary>
    /// Logika interakcji dla klasy Author.xaml
    /// </summary>
    public partial class BooksPage : UserControl
    { 
        public BooksPage()
        {
            InitializeComponent();

            AuthorsTable.ItemsSource = AuthorRepository.GetAuthorsList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AuthorPage_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            var AuthorID = Button.Tag;            
            
            Content = new AuthorPage(int.Parse(AuthorID.ToString()));
        }

        private void DeleteAuthor_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox()
            var Button = sender as Button;
            var DeleteID = int.Parse(Button.Tag.ToString());

            AuthorRepository.DeleteAuthor(DeleteID);
            Content = new BooksPage();

        }

        private void AddAuthorBTN_Click(object sender, RoutedEventArgs e)
        {
            AddAuthor window = new();
            window.Show();
        }
    }
}
