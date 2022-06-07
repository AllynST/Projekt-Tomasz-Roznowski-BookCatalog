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

namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.User
{
    /// <summary>
    /// Logika interakcji dla klasy EditUserData.xaml
    /// </summary>
    public partial class EditUserData : UserControl
    {
        public EditUserData()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            Models.User user = UserRepository.GetUserData(App.CurrentUserID);
            UsernameBox.Text = user.User_Name;
            NameBox.Text = user.Name;
            SurnameBox.Text = user.Surname;
            EmailBox.Text = user.Email;
            PasswordBox.Text = user.Password;
            CreatedBox.Text = user.CreatedDate.ToString("d");
        }

        private void EditAccount_Click(object sender, RoutedEventArgs e)
        {
            Models.User user = new()
            {
                User_Name = UsernameBox.Text,
                Name = NameBox.Text,
                Surname = SurnameBox.Text,
                Email = EmailBox.Text,
                Password = PasswordBox.Text,
                CreatedDate = DateTime.Now,
            };

            MessageBoxResult result = MessageBox.Show("Would you like to confirm changes to your account", "Confirmation",
               MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                UserRepository.ModifyUser(user);
                MessageBox.Show("User credentials changed");
                Content = new UserData();
            }
            else if (result == MessageBoxResult.No)
            {

            }

            
            
            
        }
    }
}
