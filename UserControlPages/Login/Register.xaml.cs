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
    /// Logika interakcji dla klasy Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterBTN_Click(object sender, RoutedEventArgs e)
        {
            User user = new()
                {
                    CreatedDate = DateTime.Now,
                    User_Name = UsernameBox.Text,
                    Email = EmailBox.Text,
                    Name = NameBox.Text,
                    Surname = SurnameBox.Text,
                    Password = PasswordBox.Text,

                };
            UserRepository.AddUser(user);


            User registeredUser = UserRepository.Login(user.User_Name, user.Password);
            if(registeredUser != null)
            {
                MainWindow mainwindow = new(user);
                mainwindow.Show();
                Application.Current.Windows[0].Close();
            }
            else
            {
                MessageBox.Show("Wrong credentials provided");
            }
            
            



            

        }
    }
}
