namespace OnlineRestaurant.Models
{
    public class DishViewModel
    {
        public List<DishModel> Dishes { get; set; }
        public string Category { get; set; }
        public int? Spiciness { get; set; }
        public bool? ContainsNuts { get; set; }
        public bool? Vegetarian { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
