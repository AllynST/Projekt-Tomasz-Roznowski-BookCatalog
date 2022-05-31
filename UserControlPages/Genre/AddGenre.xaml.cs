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

namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Genre
{
    /// <summary>
    /// Logika interakcji dla klasy AddGenre.xaml
    /// </summary>
    public partial class AddGenre : Window
    {
        public AddGenre()
        {
            InitializeComponent();
        }

        private void AddGenreBTN_Click(object sender, RoutedEventArgs e)
        {
            string genreTxt = GenreName.Text;
            if(genreTxt == "")
            {                
                MessageBox.Show("Input genre name first");
            }
            else
            {
                Models.Genre genre = new() { Genre_Name = genreTxt };
                GenresRepository.AddGenre(genre);
                MessageBox.Show("Genre Added");
                var window = Application.Current.Windows[2];
                window.Close();


            }
            


        }
    }
}
