using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
using Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Login;
using SQLitePCL;
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
        public static CatalogContext dbContext = new();
        public static string CurrentUser;
        public static int CurrentUserID;

        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            
            
            await dbContext.Database.EnsureCreatedAsync();
            await dbContext.SaveChangesAsync();


            Login login = new();
            login.Show();

            


        }
    }

    
}
