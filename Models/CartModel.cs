using System.ComponentModel.DataAnnotations;

namespace OnlineRestaurant.Models
{
    public class CartModel
    {
        [Key]
        public int Id { get; set; }
        public int DishId { get; set; }
        public string DishName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalCost => Price * Quantity;
    }
}