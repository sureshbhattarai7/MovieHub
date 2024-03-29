﻿using MovieManagementSystem.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagementSystem.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Actor Picture is required!")]
        [Display(Name = "Actor Picture")]
        public string? ProfilePictureUrl { get; set; }

        [Required(ErrorMessage = "Actor Name is required!")]
        [Display(Name = "Actor Full Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Actor Bio is required!")]
        [Display(Name = "Actor Bio")]
        public string? Bio { get; set; }

        //Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }

    }
}
