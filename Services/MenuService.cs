using OnlineRestaurant.Data;
using OnlineRestaurant.Interfaces;
using OnlineRestaurant.Models;

namespace OnlineRestaurant.Services
{
    public class MenuService : IMenuService
    {
        private readonly RestaurantDbContext _dbContext;

        public MenuService(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
            SeedData();
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
