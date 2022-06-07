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
    /// Logika interakcji dla klasy UserData.xaml
    /// </summary>
    public partial class UserData : UserControl
    {
        public UserData()
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

        private void EditCred_Click(object sender, RoutedEventArgs e)
        {
            Content = new EditUserData();

        }
    }
}
