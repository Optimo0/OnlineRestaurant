namespace OnlineRestaurant.Models
{
    public class DishModel
    {
        public int Id { get; set; }
        public string? DishName { get; set; }
        public string? ImageUrl { get; set; }
        public int Spiciness { get; set; }
        public bool ContainsNuts { get; set; }
        public bool IsVegetarian { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        //public List<string> Ingredients { get; set; }
        //public int Quantity { get; set; }
    }
}
