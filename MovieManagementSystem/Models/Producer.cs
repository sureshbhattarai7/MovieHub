using System.ComponentModel.DataAnnotations;

namespace MovieManagementSystem.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        [Required(ErrorMessage = "Producer Picture is required!")]
        public required string ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Producer Name is required!")]
        public required string FullName { get; set; }

        [Required(ErrorMessage = "Movie Biog is required!")]
        public required string Bio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
