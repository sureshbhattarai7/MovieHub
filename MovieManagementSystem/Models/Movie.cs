using MovieManagementSystem.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagementSystem.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie Name is required!")]
        [Display(Name = "Movie Name")]
        public string? MovieName { get; set; }

        [Required(ErrorMessage = "Movie Description is required!")]
        [Display(Name = "Movie Description")]
        public string? MovieDescription { get; set;}

        [Required(ErrorMessage = "Movie Price is required!")]
        [Display(Name = "Movie Price")]
        public string? Price { get; set;}

        [Required(ErrorMessage = "Movie Picture is required!")]
        [Display(Name = "Movie Image")]
        public string? ImageURL { get; set;}

        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set;}

        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }
    }
}
