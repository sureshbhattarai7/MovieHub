using MovieManagementSystem.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MovieManagementSystem.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Producer Picture is required!")]
        [Display(Name = "Profile Picture")]
        public string? ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Producer Name is required!")]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Movie Bio is required!")]
        [Display(Name = "Description")]
        public string? Bio { get; set; }

        //Relationship
        public List<Movie>? Movies { get; set; }
    }
}
