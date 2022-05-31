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
using Projekt_Tomasz_Roznowski_BookCatalog.Models;

namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Author
{
    /// <summary>
    /// Logika interakcji dla klasy AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : UserControl
    {
        public AuthorPage(int id)
        {
            InitializeComponent();
            
            
               Models.Author author = AuthorRepository.GetAuthorByID(id);

               AuthorName.Text = author.Name;
               AuthorSurname.Text = author.Surname;
               AuthorDate.Text = author.DateOfBirth.ToString("d");
               AuthorDesc.Text = author.Description;
        }
    }
}
