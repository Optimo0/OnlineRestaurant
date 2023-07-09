using OnlineRestaurant.Data;
using OnlineRestaurant.Models;

namespace OnlineRestaurant.Interfaces
{
    public interface IMenuService
    {
        List<DishModel> GetFilteredDishes(string category, int? spiciness, bool? containsNuts, bool? vegetarian);
        DishModel GetDishById(int dishId);
        List<CartModel> GetCartItems();
        void AddToCart(int dishId);
        void RemoveFromCart(int dishId);
        void UpdateCartItemQuantity(int dishId, int quantity);
        decimal GetTotalPrice();
    }
}