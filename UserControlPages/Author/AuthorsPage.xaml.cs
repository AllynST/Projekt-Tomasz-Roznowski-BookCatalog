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
    public partial class AuthorsPage : UserControl
    { 
        public AuthorsPage()
        {
            InitializeComponent();

            AuthorsTable.ItemsSource = AuthorRepository.GetAuthorsList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBookToAuthor_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            var AuthorID = Button.Tag;
            MessageBox.Show(AuthorID.ToString());
        }
        private void AuthorPage_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            var AuthorID = Button.Tag;            
            
            Content = new AuthorPage(int.Parse(AuthorID.ToString()));
        }
    }
}
