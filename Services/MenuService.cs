using OnlineRestaurant.Data;
using OnlineRestaurant.Interfaces;
using OnlineRestaurant.Models;

namespace OnlineRestaurant.Services
{
    public class MenuService : IMenuService
    {
        private RestaurantDbContext _dbContext;

        public MenuService(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
            SeedData();
        }

        public DishModel GetDishById(int dishId)
        {
            return _dbContext.Dishes.Find(dishId);
        }

        public void SeedData()
        {
            if (!_dbContext.Dishes.Any())
            {
                var dishes = new List<DishModel>
                {

                };

                _dbContext.Dishes.AddRange(dishes);
                _dbContext.SaveChanges();
            }
        }

        public List<CartModel> GetCartItems()
        {
            return _dbContext.CartItems.ToList();
        }

        public void AddToCart(int dishId)
        {
            var existingCartItem = _dbContext.CartItems.FirstOrDefault(item => item.DishId == dishId);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity++;
            }
            else
            {
                var dish = _dbContext.Dishes.Find(dishId);
                if (dish != null)
                {
                    _dbContext.CartItems.Add(new CartModel
                    {
                        DishId = dish.Id,
                        DishName = dish.DishName,
                        Quantity = 1,
                        Price = dish.Price
                    });
                }
            }
            _dbContext.SaveChanges();
        }

        public void RemoveFromCart(int dishId)
        {
            var existingCartItem = _dbContext.CartItems.FirstOrDefault(item => item.DishId == dishId);

            if (existingCartItem != null)
            {
                _dbContext.CartItems.Remove(existingCartItem);
            }
            _dbContext.SaveChanges();
        }

        public void UpdateCartItemQuantity(int dishId, int quantity)
        {
            var existingCartItem = _dbContext.CartItems.FirstOrDefault(item => item.DishId == dishId);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity = quantity;
            }
            _dbContext.SaveChanges();
        }

        public List<DishModel> GetFilteredDishes(string category, int? spiciness, bool? containsNuts, bool? vegetarian)
        {
            IQueryable<DishModel> filteredDishes = _dbContext.Dishes.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                filteredDishes = filteredDishes.Where(d => d.Category == category);
            }

            if (spiciness.HasValue)
            {
                filteredDishes = filteredDishes.Where(d => d.Spiciness == spiciness.Value);
            }

            if (containsNuts.HasValue)
            {
                filteredDishes = filteredDishes.Where(d => d.ContainsNuts == containsNuts.Value);
            }

            if (vegetarian.HasValue)
            {
                filteredDishes = filteredDishes.Where(d => d.IsVegetarian == vegetarian.Value);
            }

            return filteredDishes.ToList();
        }
    }
}