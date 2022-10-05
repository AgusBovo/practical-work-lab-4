using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAppMVC_EF.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Publication Date")]
        public DateTime publicationdate { get; set; }

        [Display(Name = "Genre of the book")]
        public string Genre { get; set; }

        public string foto { get; set; }

    }
}
