using System.ComponentModel.DataAnnotations;

namespace MovieManagementSystem.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        [Required(ErrorMessage = "Cinema Picture is required!")]
        public required string CinemaLogo { get; set; }

        [Required(ErrorMessage = "Cinema Name is required!")]
        public required string CinemaName { get; set; }

        [Required(ErrorMessage = "Movie Description is required!")]
        public required string Description { get; set; }
    }
}
