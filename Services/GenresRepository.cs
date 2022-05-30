﻿using Microsoft.EntityFrameworkCore;
using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Services
{
    public static class GenresRepository
    {
        private static CatalogContext _context = new();


        public static List<Genre> GetGenres()
        {
            return _context.Genres.Include(x=>x.Books).ToList();
        }

        public static Genre GetGenreById(int id)
        {
            Genre query = _context.Genres.Include(x => x.Books).Where(item => item.Genre_ID == id).First();

            return query;
        }
    }
}
