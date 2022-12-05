using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApi.Models
{
    public class CreateDishDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int RestaurantId { get; set; }
    }
}
