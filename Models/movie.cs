using System;
using System.ComponentModel.DataAnnotations;


namespace MoviesListed.Models
{
    public class Movie
    {

        // EF will instruct the database to automatically generate this value
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a movie Name.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year .")]

        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a Rating.")]

        public double Rating { get; set; }

        [Required(ErrorMessage = "Please enter a Description.")]

        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter Actors/Actresses.")]

        public string Actors { get; set; }



        [Required(ErrorMessage = "Please enter a Runtime.")]

        public double? Runtime { get; set; }


        [Required(ErrorMessage = "Please select a Genre.")]

        public string ListsID { get; set; }

        public Lists Lists { get; set; }

        public string Slug =>
            Title?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}


