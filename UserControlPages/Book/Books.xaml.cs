using Projekt_Tomasz_Roznowski_BookCatalog.Data;
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

namespace Projekt_Tomasz_Roznowski_BookCatalog
{
    /// <summary>
    /// Logika interakcji dla klasy Books.xaml
    /// </summary>
    public partial class Books : UserControl
    {
        public Books()
        {
            async void Local()
            {
                BooksTable.ItemsSource = await BooksRepository.GetBooks();
            }

            InitializeComponent();
            Local();
        }

        private void BookPage_Click(object sender, RoutedEventArgs e)
        {
        
        }

    }
}
