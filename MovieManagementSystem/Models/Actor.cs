using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
