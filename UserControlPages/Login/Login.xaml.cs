using Projekt_Tomasz_Roznowski_BookCatalog.Models;
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

namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Login
{
    /// <summary>
    /// Logika interakcji dla klasy Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerTxt_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {           

            Register register = new();
            register.Show();           
            Application.Current.Windows[0].Close();

        }
               

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {            

            string Login = LoginBox.Text;
            string Password = PasswordBox.Password;

            User user = UserRepository.Login(Login, Password);

            if(user != null)
            {
                MainWindow window = new MainWindow(user);
                App.CurrentUser = user.User_Name;
                window.Show();
                Application.Current.Windows[0].Close();
            }
            else
            {
                LoginBox.Text = "";
                PasswordBox.Password = "";
                MessageBox.Show("Wrong credentials");

            }

            

            



            

        }
    }
}
