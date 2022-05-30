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
    static class AuthorRepository
    {
        private static CatalogContext _context = new();


        public static List<Author> GetAuthorsList()
        {

            return _context.Authors.Include(x=>x.Books).ToList();
        }

        public static Author GetAuthorByID(int id)
        {
            return _context.Authors.Include(x=>x.Books).Where(item=> item.Author_ID == id).First();
        }


    }
}
