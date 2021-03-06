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

namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Genre
{
    /// <summary>
    /// Logika interakcji dla klasy GenreList.xaml
    /// </summary>
    public partial class GenreList : UserControl
    {
        public GenreList()
        {          
               
           
            
            InitializeComponent();
            GenreTable.ItemsSource = GenresRepository.GetGenres();
            
        }

        private void DisplayGenreBooksBTN_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            var BookID = Button.Tag;

            Content = new GenreDetails(int.Parse(BookID.ToString()));
            MessageBox.Show(BookID.ToString());
        }

        private void AddGenreBTN_Click(object sender, RoutedEventArgs e)
        {
            AddGenre AddGenreWindow = new();            
            AddGenreWindow.Show();
        }

        private void DeleteGenreBTN_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            var DeleteID = int.Parse(Button.Tag.ToString());

            MessageBoxResult result = MessageBox.Show("Do you want to delete this genre?", "Confirmation",
              MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                GenresRepository.DeleteGenre(DeleteID);
                MessageBox.Show("Genre deleted");                
                Content = new GenreList();
            }
            else if (result == MessageBoxResult.No)
            {

            }
            
            
        }
    }
}
