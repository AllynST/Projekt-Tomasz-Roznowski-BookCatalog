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
            return _context.Books.ToList();
        }

    }
}
