using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Models
{
    public class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();            
        }
        [Key]
        public int Author_ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public ICollection<Book>? Books { get; set; }
        public DateTime DateOfBirth { get; set; }

        


    }
}
