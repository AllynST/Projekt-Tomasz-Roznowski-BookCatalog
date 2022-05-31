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
        public static List<Book> GetReadList(int id)
        {
            return _context.Users.Find(id).ReadList.ToList() ;
        }
        public static void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
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
            User before = _context.Users.Find(user.User_ID);

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
