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
    /// Logika interakcji dla klasy EditBook.xaml
    /// </summary>
    public partial class EditBook : Window
    {

        private int BookID;
        public EditBook(int BookID)
        {
            this.BookID = BookID;
            InitializeComponent();
            BookFormat.ItemsSource = Enum.GetValues(typeof(Models.Format)).Cast<Models.Format>();
            BookGenre.ItemsSource = GenresRepository.GetGenres();
            BookAuthor.ItemsSource = AuthorRepository.GetAuthorsList();
        }

        private void EditBookBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Models.Book book = new()
                {
                    Title = BookTitle.Text,
                    Genre = (Models.Genre)BookGenre.SelectedItem,
                    Author = (Models.Author)BookAuthor.SelectedItem,
                    Format = (Models.Format)BookFormat.SelectedItem,
                    Language = BookLang.Text,
                    Description = BookDesc.Text
                };
                
                MessageBoxResult result = MessageBox.Show("Confirm book modification", "Confirmation",
                MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    BooksRepository.ModifyBook(book, this.BookID);
                    MessageBox.Show("Book modified");                    
                    Close();
                }
                else if (result == MessageBoxResult.No)
                {

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Provide correct data first");
            }
            
            
            

            

        }
    }
}
