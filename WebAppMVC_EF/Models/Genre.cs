using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAppMVC_EF.Models
{
    public class Genre
    {
        public int ID { get; set; }

        [Display(Name = "Genre")]
        public string genres { get; set; }
    }
}
