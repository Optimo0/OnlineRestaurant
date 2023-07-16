using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineRestaurant.Models
{
    [Table("Dishes")]
    public class DishModel
    {
        [Key]
        public int Id { get; set; }
        public string? DishName { get; set; }
        public string? ImageUrl { get; set; }
        public int Spiciness { get; set; }
        public bool? ContainsNuts { get; set; }
        public bool? IsVegetarian { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}