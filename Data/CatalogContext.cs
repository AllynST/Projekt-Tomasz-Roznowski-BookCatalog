using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Data
{
    public class CatalogContext :DbContext
    {       
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BookCatalog.db", option => {
                option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<Genre>().ToTable("Genres");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Review>().ToTable("Reviews");

        }









    }
}
