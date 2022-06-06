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
    public static class BooksRepository
    {
        private static CatalogContext _context = new();


        public static List<Book> GetBooks()
        {
            return _context.Books.Include(x=>x.Author).Include(y=>y.Genre).ToList();
        }

        public static Book GetBook(int id)
        {
            return _context.Books.Include(x=>x.Author).Include(x=>x.Genre).Where(x=>x.Book_ID == id).FirstOrDefault();
        }

        public static void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public static void DeleteBook(int id)
        {
            //NIEPRZESTESTOWANE
            Book book = _context.Books.Find(id);
            _context.Remove(book);
            _context.SaveChanges();

        }

        public static void ModifyBook(Book book)
        {

            //UNTESTED
            Book before = _context.Books.Find(book.Book_ID);

            before.Title = book.Title;
            before.Author = book.Author;
            before.Format = book.Format;
            before.Language = book.Language;

            _context.Books.Update(before);
            _context.SaveChanges();

        }

    }
}
