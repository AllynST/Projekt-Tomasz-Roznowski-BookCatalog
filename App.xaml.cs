using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
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

        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            Author author = new Author() { Surname = "mickiewsicz", Name = "adaś" };
            
            
            await dbContext.Database.EnsureCreatedAsync();

            /*dbContext.Users.Add(
                new User() { User_Name = "Allyn", Name = "Allan", Surname = "Surname", Password = "zaq1WSX", Email = "Allyn@gmail.com", CreatedDate = DateTime.Now }
                );*/

            Author testAuthor = new Author()
            {
                Author_ID = 11,
                Surname = "Olaf",
                Name = "Iskra",                
                Description = "Ciekawy zawodnik jest grany",
                DateOfBirth = new DateTime(2000, 12, 12)


            };

            Book testBook = new Book()
            {
                Title = "Dziady",
                Genre = new Genre()
                {
                    Genre_Name = "Fantasy"
                },
                Language="Spanglish",
                Format=Format.MOBI,
                Author = testAuthor
            };

            /*dbContext.Books.Add(testBook); */           

            /*dbContext.Authors.Add(testAuthor);  */




            await dbContext.SaveChangesAsync();

            
            MainWindow mainWindow = new();
            mainWindow.Show();


        }
    }

    
}
