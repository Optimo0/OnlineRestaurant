using OnlineRestaurant.Migrations;
using OnlineRestaurant.Models;

namespace OnlineRestaurant.Services
{
    public class MenuService
    {
        private List<DishModel> allDishes;

        public MenuService() 
        {
            allDishes = new List<DishModel>
            {
                // Salads
                new DishModel
                {
                    Id = 1,
                    DishName = "Caesar Salad",
                    ImageUrl = "Caesar Salad",
                    Spiciness = 0,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 12,
                    Category = "Salads",
                },
                new DishModel
                {
                    Id = 2,
                    DishName = "Greek Salad",
                    ImageUrl = "Greek Salad",
                    Spiciness = 2,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 10,
                    Category = "Salads",
                },
                new DishModel
                {
                    Id = 3,
                    DishName = "Caprese Salad",
                    ImageUrl = "Caprese Salad",
                    Spiciness = 0,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 13,
                    Category = "Salads",
                },
                new DishModel
                {
                    Id = 4,
                    DishName = "Cobb Salad",
                    ImageUrl = "Cobb Salad",
                    Spiciness = 1,
                    ContainsNuts = true,
                    IsVegetarian = true,
                    Price = 16,
                    Category = "Salads",
                },
                new DishModel
                {
                    Id = 5,
                    DishName = "Thai Beef Salad",
                    ImageUrl = "Thai Beef Salad",
                    Spiciness = 3,
                    ContainsNuts = true,
                    IsVegetarian = false,
                    Price = 18,
                    Category = "Salads",
                },
                // Soups
                new DishModel
                {
                    Id = 6,
                    DishName = "Tomato Basil Soup",
                    ImageUrl = "Tomato Basil Soup",
                    Spiciness = 1,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 6,
                    Category = "Soups",
                },
                new DishModel
                {
                    Id = 7,
                    DishName = "Chicken Tortilla Soup",
                    ImageUrl = "Chicken Tortilla Soup",
                    Spiciness = 2,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 9,
                    Category = "Soups",
                },
                new DishModel
                {
                    Id = 8,
                    DishName = "Tom Yum Soup",
                    ImageUrl = "Tom Yum Soup",
                    Spiciness = 3,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 14,
                    Category = "Soups",
                },
                new DishModel
                {
                    Id = 9,
                    DishName = "Sichuan Hot and Sour Soup",
                    ImageUrl = "Sichuan Hot and Sour Soup",
                    Spiciness = 4,
                    ContainsNuts = true,
                    IsVegetarian = false,
                    Price = 11,
                    Category = "Soups",
                },
                new DishModel
                {
                    Id = 10,
                    DishName = "Butternut Squash Soup",
                    ImageUrl = "Butternut Squash Soup",
                    Spiciness = 0,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 7,
                    Category = "Soups",
                },
                // Chicken-Dishes
                new DishModel
                {
                    Id = 11,
                    DishName = "Lemon Herb Grilled Chicken",
                    ImageUrl = "Lemon Herb Grilled Chicken",
                    Spiciness = 1,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 18,
                    Category = "Chicken-Dishes",
                },
                new DishModel
                {
                    Id = 12,
                    DishName = "Chicken Curry",
                    ImageUrl = "Chicken Curry",
                    Spiciness = 2,
                    ContainsNuts = true,
                    IsVegetarian = false,
                    Price = 20,
                    Category = "Chicken-Dishes",
                },
                new DishModel
                {
                    Id = 13,
                    DishName = "Honey Sriracha Chicken",
                    ImageUrl = "Honey Sriracha Chicken",
                    Spiciness = 3,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 19,
                    Category = "Chicken-Dishes",
                },
                new DishModel
                {
                    Id = 14,
                    DishName = "Nashville Hot Chicken",
                    ImageUrl = "Nashville Hot Chicken",
                    Spiciness = 4,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 22,
                    Category = "Chicken-Dishes",
                },
                new DishModel
                {
                    Id = 15,
                    DishName = "Baked Lemon Pepper Chicken",
                    ImageUrl = "Baked Lemon Pepper Chicken",
                    Spiciness = 0,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 17,
                    Category = "Chicken-Dishes",
                },
                // Beef-Dishes
                new DishModel
                {
                    Id = 16,
                    DishName = "Beef and Broccoli Stir-Fry",
                    ImageUrl = "Beef and Broccoli Stir-Fry",
                    Spiciness = 1,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 15,
                    Category = "Beef-Dishes",
                },
                new DishModel
                {
                    Id = 17,
                    DishName = "Szechuan Beef",
                    ImageUrl = "Szechuan Beef",
                    Spiciness = 2,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 21,
                    Category = "Beef-Dishes",
                },
                new DishModel
                {
                    Id = 18,
                    DishName = "Thai Basil Beef",
                    ImageUrl = "Thai Basil Beef",
                    Spiciness = 3,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 17,
                    Category = "Beef-Dishes",
                },
                new DishModel
                {
                    Id = 19,
                    DishName = "Korean Spicy Beef Stir-Fry",
                    ImageUrl = "Korean Spicy Beef Stir-Fry",
                    Spiciness = 4,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 25,
                    Category = "Beef-Dishes",
                },
                new DishModel
                {
                    Id = 20,
                    DishName = "Classic Beef Stew",
                    ImageUrl = "Classic Beef Stew",
                    Spiciness = 0,
                    ContainsNuts = true,
                    IsVegetarian = false,
                    Price = 28,
                    Category = "Beef-Dishes",
                },
                // Vegetable-Dishes
                new DishModel
                {
                    Id = 21,
                    DishName = "Thai Red Curry Vegetables",
                    ImageUrl = "Thai Red Curry Vegetables",
                    Spiciness = 1,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 10,
                    Category = "Vegetable-Dishes",
                },
                new DishModel
                {
                    Id = 22,
                    DishName = "Chili Garlic Tofu Stir-Fry",
                    ImageUrl = "Chili Garlic Tofu Stir-Fry",
                    Spiciness = 2,
                    ContainsNuts = true,
                    IsVegetarian = true,
                    Price = 16,
                    Category = "Vegetable-Dishes",
                },
                new DishModel
                {
                    Id = 23,
                    DishName = "Thai Basil Eggplant",
                    ImageUrl = "Thai Basil Eggplant",
                    Spiciness = 3,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 12,
                    Category = "Vegetable-Dishes",
                },
                new DishModel
                {
                    Id = 24,
                    DishName = "Korean Kimchi Fried Rice",
                    ImageUrl = "Korean Kimchi Fried Rice",
                    Spiciness = 14,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 14,
                    Category = "Vegetable-Dishes",
                },
                new DishModel
                {
                    Id = 25,
                    DishName = "Roasted Garlic Broccoli",
                    ImageUrl = "Roasted Garlic Broccoli",
                    Spiciness = 0,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 10,
                    Category = "Vegetable-Dishes",
                },
                // Bits&Slices
                new DishModel
                {
                    Id = 26,
                    DishName = "Jalapeno Poppers",
                    ImageUrl = "Jalapeno Poppers",
                    Spiciness = 2,
                    ContainsNuts = true,
                    IsVegetarian = true,
                    Price = 8,
                    Category = "Bits&Bites",
                },
                new DishModel
                {
                    Id = 27,
                    DishName = "Buffalo Cauliflower Bites",
                    ImageUrl = "Buffalo Cauliflower Bites",
                    Spiciness = 3,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 13,
                    Category = "Bits&Bites",
                },
                new DishModel
                {
                    Id = 28,
                    DishName = "Shrimp Skewers",
                    ImageUrl = "Shrimp Skewers",
                    Spiciness = 4,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 16,
                    Category = "Bits&Bites",
                },
                new DishModel
                {
                    Id = 29,
                    DishName = "Garlic Parmesan Breadsticks",
                    ImageUrl = "Garlic Parmesan Breadsticks",
                    Spiciness = 0,
                    ContainsNuts = false,
                    IsVegetarian = false,
                    Price = 7,
                    Category = "Bits&Bites",
                },
                new DishModel
                {
                    Id = 30,
                    DishName = "Tuna Tartare Bites",
                    ImageUrl = "Tuna Tartare Bites",
                    Spiciness = 1,
                    ContainsNuts = true,
                    IsVegetarian = false,
                    Price = 12,
                    Category = "Bits&Bites",
                },
                // On The Side
                new DishModel
                {
                    Id = 31,
                    DishName = "Cajun Fries",
                    ImageUrl = "Cajun Fries",
                    Spiciness = 2,
                    ContainsNuts = true,
                    IsVegetarian = false,
                    Price = 4,
                    Category = "On The Side",
                },
                new DishModel
                {
                    Id = 32,
                    DishName = "Garlic Parmesan Roasted Potatoes",
                    ImageUrl = "Garlic Parmesan Roasted Potatoes",
                    Spiciness = 0,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 5,
                    Category = "On The Side",
                },
                new DishModel
                {
                    Id = 33,
                    DishName = "Mexican Street Corn",
                    ImageUrl = "Mexican Street Corn",
                    Spiciness = 3,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 9,
                    Category = "On The Side",
                },
                new DishModel
                {
                    Id = 34,
                    DishName = "Coleslaw with a Kick",
                    ImageUrl = "Coleslaw with a Kick",
                    Spiciness = 1,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 3,
                    Category = "On The Side",
                },
                new DishModel
                {
                    Id = 35,
                    DishName = "Mac and Cheese",
                    ImageUrl = "Mac and Cheese",
                    Spiciness = 7,
                    ContainsNuts = false,
                    IsVegetarian = true,
                    Price = 6,
                    Category = "On The Side",
                },
            };
        }
        public List<DishModel> GetFilteredDishes(string category, int? spiciness, bool? containsNuts, bool? vegetarian)
        {
            List<DishModel> filteredDishes = allDishes;

            if (!string.IsNullOrEmpty(category))
            {
                filteredDishes = filteredDishes.Where(d => d.Category == category).ToList();
            }

            if (spiciness.HasValue)
            {
                filteredDishes = filteredDishes.Where(d => d.Spiciness == spiciness.Value).ToList();
            }

            if (containsNuts.HasValue)
            {
                filteredDishes = filteredDishes.Where(d => d.ContainsNuts == containsNuts.Value).ToList();
            }

            if (vegetarian.HasValue)
            {
                filteredDishes = filteredDishes.Where(d => d.IsVegetarian == vegetarian.Value).ToList();
            }

            return filteredDishes;

        }
    }
}
