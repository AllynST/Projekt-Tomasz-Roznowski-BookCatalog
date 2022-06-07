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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book
{
    /// <summary>
    /// Logika interakcji dla klasy Book.xaml
    /// </summary>
    public partial class Genre : UserControl
    {
        private int BookID { get; set; }
        public Genre(int id)
        {
            this.BookID = id;
            InitializeComponent();
            Models.Book book = BooksRepository.GetBook(id);
            LoadData(book);
        }

        public void LoadData(Models.Book book)
        {
            BookTitle.Text = book.Title;
            Author.Text = $"{book.Author.Name} {book.Author.Surname}";
            Language.Text = book.Language;
            Format.Text = book.Format.ToString();
            BookDesc.Text = book.Description;
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {           
            EditBook window = new(this.BookID);
            window.Show();
        }
    }
}
