using Projekt_Tomasz_Roznowski_BookCatalog.Data;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {            
            InitializeComponent();            
        }
       
        private void Books_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Books();
        }

        private void Authors_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new AuthorPage();
        }

        private void Genres_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReadList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FBooks_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
