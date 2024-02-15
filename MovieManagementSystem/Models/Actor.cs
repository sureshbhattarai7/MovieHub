using System.ComponentModel.DataAnnotations;

namespace MovieManagementSystem.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Required(ErrorMessage = "Actor Picture is required!")]
        public required string ProfilePictureUrl { get; set; }

        [Required(ErrorMessage = "Actor Name is required!")]
        public required string FullName { get; set; }

        [Required(ErrorMessage = "Actor Bio is required!")]
        public required string Bio { get; set; }
    }
}
