using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Models
{
    public class Book
    {
        public Book()
        {
            Reviews = new HashSet<Review>();
        }
        [Key]
        public int Book_ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre? Genre { get; set; }
        public ICollection<Review>? Reviews { get; set; }    
        public string Language { get; set; }
        public Author Author { get; set; }        
        public Format Format { get; set; }
    }

    public enum Format
    {
        PDF,
        MOBI,
        EPUB
    }
}
