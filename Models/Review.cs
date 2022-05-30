using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Tomasz_Roznowski_BookCatalog.Models
{
    public class Review
    {
        [Key]

        public int Review_ID { get; set; }
        public User AddedBy { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        //public int likes{get;set;} 

    }
}
