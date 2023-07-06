using Microsoft.EntityFrameworkCore;
using OnlineRestaurant.Models;

namespace OnlineRestaurant.Data
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<DishModel> Dishes { get; set; }
        public DbSet<CartModel> CartItems { get; set; }

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishModel>()
                .Property(d => d.Price)
                .HasColumnType("decimal(6, 2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}