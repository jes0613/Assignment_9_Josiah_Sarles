using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_9_Josiah_Sarles.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int movieID { get; set; }

        [Required(ErrorMessage = "Please enter a movie category")]
        public string category { get; set; }

        [Required(ErrorMessage = "Please enter the movie title")]
        public string title { get; set; }

        [Required(ErrorMessage = "Please enter the year the movie was released")]
        public int year { get; set; }

        [Required(ErrorMessage = "Please enter the director's name")]
        public string director { get; set; }

        [Required(ErrorMessage = "Please enter the movie rating")]
        public string rating { get; set; }

        public string? edited { get; set; }

        public string? lent { get; set; }

        [MaxLength(25)]
        public string? notes { get; set; }

    }
}
