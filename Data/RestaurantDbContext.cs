using Microsoft.EntityFrameworkCore;
using OnlineRestaurant.Models;

namespace OnlineRestaurant.Data
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<DishModel> Dishes { get; set; }

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) 
        {

        }
    }
}
