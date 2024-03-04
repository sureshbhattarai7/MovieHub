using MovieManagementSystem.Data.Base;
using MovieManagementSystem.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagementSystem.Models
{
    public class NewMovieVM
    {
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Movie Name is required!")]
        public string? MovieName { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Movie Description is required!")]
        public string? MovieDescription { get; set;}

        [Display(Name = "Movie Price")]
        [Required(ErrorMessage = "Movie Price is required!")]
        public double Price { get; set;}

        [Display(Name = "Movie Image")]
        [Required(ErrorMessage = "Movie Picture is required!")]
        public string? ImageURL { get; set;}

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date is required!")]
        public DateTime StartDate {  get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date is required!")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie Genre")]
        [Required(ErrorMessage = "Select a Movie Genre")]
        public MovieCategory MovieCategory { get; set;}

        //Relationship
        [Display(Name = "Select Actors")]
        [Required(ErrorMessage = "Movie Actor is required!")]
        public List<int>? ActorIds { get; set; }

        [Display(Name = "Select Cinema")]
        [Required(ErrorMessage = "Movie Cinema is required!")]
        public int CinemaId { get; set; }

        [Display(Name = "Select Producer")]
        [Required(ErrorMessage = "Movie Producer is required!")]
        public int ProducerId { get; set; }
    
    }
}
