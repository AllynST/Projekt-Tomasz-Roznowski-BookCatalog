using Microsoft.EntityFrameworkCore;
using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Services
{
    public static class UserRepository
    {
        private static CatalogContext _context = new();


        public static User GetUserData(int id)
        {
            return _context.Users.Find(id);
        }
        public static List<Book> GetReadList(string UserName)
        {
            return _context.Users.Where(x => x.User_Name == UserName).AsNoTracking().Include(x => x.ReadList).FirstOrDefault().ReadList.ToList();
        }
        public static List<Book> GetFinishedBooks(string UserName)
        {
            return _context.Users.Where(x => x.User_Name == UserName).AsNoTracking().Include(x => x.FinishedBooks).FirstOrDefault().FinishedBooks.ToList();
        }

        public static void AddToFinishedList(string UserName, Book book)
        {
            User user = _context.Users.Where(x => x.User_Name == UserName).FirstOrDefault();
            user.ReadList.Remove(book);
            user.FinishedBooks.Add(book);
            _context.Users.Update(user);
            _context.SaveChanges();

        }


        public static void AddToReadList(string UserName, Book book)
        {
            User user = _context.Users.Where(x => x.User_Name == UserName).FirstOrDefault();
            user.ReadList.Add(book);
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public static void DeleteFromReadList(string Username,int BookID) {
            Book book = _context.Books.Find(BookID);
            User user = _context.Users.Where(x=>x.User_Name == Username).FirstOrDefault();
            user.ReadList.Remove(book);
            _context.SaveChanges();
        }
        public static void DeleteFromFinished(string Username, int BookID) {
            Book book = _context.Books.Find(BookID);
            User user = _context.Users.Where(x => x.User_Name == Username).FirstOrDefault();
            user.FinishedBooks.Remove(book);
            _context.SaveChanges();
        }
        public static void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        
        public static User Login(string Login,string Password)
        {
            return _context.Users.Where(x=>x.User_Name == Login).Where(x=>x.Password == Password).FirstOrDefault();
        }
        public static void DeleteUser(int id)
        {
            
            //UNTESTED
            User user = _context.Users.Find(id);
            _context.Remove(user);
            _context.SaveChanges ();
        }
        public static void ModifyUser(User user)
        {

            //UNTESTED
            User before = _context.Users.Find(App.CurrentUserID);

            before.User_Name = user.User_Name;
            before.Surname = user.Surname;
            before.Email = user.Email;
            before.Name = user.Name;
            before.Password = user.Password;  
            
            _context.Users.Update(before);
            _context.SaveChanges();

        }
        
    }
}
