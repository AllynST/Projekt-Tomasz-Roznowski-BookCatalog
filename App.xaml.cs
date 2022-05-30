using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Projekt_Tomasz_Roznowski_BookCatalog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public CatalogContext _context = new CatalogContext();
        

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Author author = new Author() { Surname = "mickiewsicz", Name = "adaś" };

            _context.Authors.Add(author);

            
            MainWindow mainWindow = new();
            mainWindow.Show();
        }
    }

    
}
