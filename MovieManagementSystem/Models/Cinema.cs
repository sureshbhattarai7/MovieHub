using System.ComponentModel.DataAnnotations;

namespace MovieManagementSystem.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Cinema Picture is required!")]
        [Display(Name = "Cinema Logo")]
        public string? CinemaLogo { get; set; }

        [Required(ErrorMessage = "Cinema Name is required!")]
        [Display(Name = "Cinema Name")]
        public string? CinemaName { get; set; }

        [Required(ErrorMessage = "Cinema Description is required!")]
        [Display(Name = "Cinema Description")]
        public string? Description { get; set; }

        //Relationship
        public List<Movie>? Movies { get; set; }
    }
}
