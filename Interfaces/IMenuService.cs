using OnlineRestaurant.Models;

namespace OnlineRestaurant.Interfaces
{
    public interface IMenuService
    {
        List<DishModel> GetFilteredDishes(string category, int? spiciness, bool? containsNuts, bool? vegetarian);
    }
}
