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

namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book
{
    /// <summary>
    /// Logika interakcji dla klasy AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
       
        public AddBook(){
            
            InitializeComponent();
            LoadComponentsData();
        }

        public void LoadComponentsData()
        {
            BookFormat.ItemsSource = Enum.GetValues(typeof(Models.Format)).Cast<Models.Format>();
            BookGenre.ItemsSource = GenresRepository.GetGenres();
           BookAuthor.ItemsSource = AuthorRepository.GetAuthorsList();

        }

        private void AddBookBTN_Click(object sender, RoutedEventArgs e)
        {
            int AuthorID = ((Models.Author)BookAuthor.SelectedItem).Author_ID;

            
            Models.Book book = new()
            {
                Title = BookTitle.Text,                            
                Genre = (Models.Genre)BookGenre.SelectedItem,
                Format = (Models.Format)BookFormat.SelectedItem,
                Language = BookLang.Text,
                Description = BookDesc.Text
            };

            AuthorRepository.AddBookToAuthor(AuthorID,book);

            MessageBox.Show("Book Added");

            Application.Current.Windows[2].Close();

            Content = new BooksPage();
        }
    }
}
