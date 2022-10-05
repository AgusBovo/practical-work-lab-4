using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAppMVC_EF.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Forename")]
        public string Forename { get; set; }
        [Display(Name = "Biography")]
        public string Biography { get; set; }

        public string picture { get; set; }
    }
}
