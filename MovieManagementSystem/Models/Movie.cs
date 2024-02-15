using MovieManagementSystem.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MovieManagementSystem.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie Name is required!")]
        public required string MovieName { get; set; }

        [Required(ErrorMessage = "Movie Description is required!")]
        public required string MovieDescription { get; set;}

        [Required(ErrorMessage = "Movie Price is required!")]
        public required string Price { get; set;}

        [Required(ErrorMessage = "Movie Picture is required!")]
        public required string ImageURL { get; set;}

        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set;}
    }
}
