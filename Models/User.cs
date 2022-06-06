using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Models
{
    public class User
    {

        public User()
        {
            FinishedBooks = new HashSet<Book>();
            ReadList = new HashSet<Book>();
        }
        [Key]
        public int User_ID { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public ICollection<Book>? FinishedBooks { get; set; }
        public ICollection<Book>? ReadList { get; set; }

    }
}
