using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
using Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book;
using Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Genre;
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
        public User user;
        

        public MainWindow(User user)
        {
            this.user = user;
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            AccountUserName.Text = user.User_Name;
            AccountMail.Text = user.Email;
            App.CurrentUser = user.User_Name;
        }
       
        private void Books_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Books();
        }

        private void Authors_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BooksPage();
        }

        private void Genres_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new GenreList();
        }

        private void ReadList_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ReadList();
        }

        private void FBooks_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new FinishedBooks();
        }

        private void TOOLBAR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ExitAPP_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
