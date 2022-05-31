using Projekt_Tomasz_Roznowski_BookCatalog.Data;
using Projekt_Tomasz_Roznowski_BookCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Services
{
    public static class ReviewRepository
    {
        private static CatalogContext _context = new();

        public static void DeleteReview(int id)
        {
            Review review = _context.Reviews.Find(id);
            _context.Reviews.Remove(review);
            _context.SaveChanges();
        }
    }
}
