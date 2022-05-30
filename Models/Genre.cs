using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Models
{
    public class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }
        [Key]
        public int Genre_ID { get; set; }
        [Required]
        public string Genre_Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
