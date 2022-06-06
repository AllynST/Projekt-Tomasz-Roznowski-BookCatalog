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
    /// Logika interakcji dla klasy FinishedBooks.xaml
    /// </summary>
    public partial class FinishedBooks : UserControl
    {
        public FinishedBooks()
        {
            InitializeComponent();

            FinishedTable.ItemsSource = UserRepository.GetFinishedBooks(App.CurrentUser);
            
        }

        private void RemoveFromFinished_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            int BookID = int.Parse(Button.Tag.ToString());

            UserRepository.DeleteFromFinished(App.CurrentUser,BookID);

            Content = new FinishedBooks();
        }
    }
}
