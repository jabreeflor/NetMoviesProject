using System.ComponentModel.DataAnnotations;

namespace MoviesListed.Models
{
    public class Lists
    {
        [Required(ErrorMessage = "Please select a class standing")]
        public string ListsID { get; set; }
        public string mTitle { get; set; }
    }
}

