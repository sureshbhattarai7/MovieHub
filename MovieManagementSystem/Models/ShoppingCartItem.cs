using System.ComponentModel.DataAnnotations;

namespace MovieManagementSystem.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Movie Movie { get; set; }

        public int Amount { get; set; }
        public int ShoppingCartId { get; set; }
    }
}
