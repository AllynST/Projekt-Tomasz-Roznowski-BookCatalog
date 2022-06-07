using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Services;
using Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book;
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
    /// Logika interakcji dla klasy Books.xaml
    /// </summary>
    public partial class Books : UserControl
    {
        public Books()
        {    

            InitializeComponent();
            BooksTable.ItemsSource = BooksRepository.GetBooks();

        }

        private void BookPage_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            int BookID = int.Parse(Button.Tag.ToString());

            Content = new Genre(BookID);
        }

        private void AddBookBTN_Click(object sender, RoutedEventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void DeleteBookBTN_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            int BookID = int.Parse(Button.Tag.ToString());
              

            MessageBoxResult result = MessageBox.Show("Confirm book deletion","Confirmation",
                MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                BooksRepository.DeleteBook(BookID);

                Content = new Books();
            }
            else if(result == MessageBoxResult.No)
            {
                
            }

        }
        private void FilterBTN_Click(object sender, RoutedEventArgs e)
        {            
            string filter = FilterBox.SelectedItem.ToString().Split(' ')[1] ; 
            
            if(filter == "No")
            {
                BooksTable.ItemsSource = BooksRepository.GetBooks();
            }
            else
            {
                BooksTable.ItemsSource = BooksRepository.GetBooks().Where(x=>x.Format.ToString() == filter);
            }
            
            
        }

        private void AddReadList_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            int BookID = int.Parse(Button.Tag.ToString());

            Models.Book book = BooksRepository.GetBook(BookID);

            UserRepository.AddToReadList(App.CurrentUser, book);
        }
    }
}
