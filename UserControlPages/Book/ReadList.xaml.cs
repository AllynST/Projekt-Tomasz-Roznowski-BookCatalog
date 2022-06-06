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
    /// Logika interakcji dla klasy ReadList.xaml
    /// </summary>
    public partial class ReadList : UserControl
    {
        public ReadList()
        {
            
            InitializeComponent();

            ReadListTable.ItemsSource = UserRepository.GetReadList(App.CurrentUser);  
        }

        private void Finished_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            int BookID = int.Parse(Button.Tag.ToString());

            Models.Book book = BooksRepository.GetBook(BookID);
            UserRepository.AddToFinishedList(App.CurrentUser, book);

            Content = new ReadList();
        }

        private void DeleteBookFromReadListBTN_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            int BookID = int.Parse(Button.Tag.ToString());

            UserRepository.DeleteFromReadList(App.CurrentUser, BookID);

            Content = new ReadList();
        }
    }
}
