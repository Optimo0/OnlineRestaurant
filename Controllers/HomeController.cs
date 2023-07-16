using Microsoft.AspNetCore.Mvc;
using OnlineRestaurant.Models;
using System.Diagnostics;
using OnlineRestaurant.Services;
using OnlineRestaurant.Interfaces;
using Microsoft.AspNetCore.Http;

namespace OnlineRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMenuService _menuService;

        public HomeController(ILogger<HomeController> logger, IMenuService menuService)
        {
            _logger = logger;
            _menuService = menuService;
        }

        public IActionResult Index(string category, int? spiciness, bool? containsNuts, bool? vegetarian, int page = 1)
        {
            int pageSize = 6;

            List<DishModel> dishes = _menuService.GetFilteredDishes(category, spiciness, containsNuts, vegetarian);

            int totalItems = dishes.Count;
            int totalPages = (int)Math.Ceiling((decimal)totalItems / pageSize);

            dishes = dishes.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new DishViewModel
            {
                Dishes = dishes,
                Category = category,
                Spiciness = spiciness,
                ContainsNuts = containsNuts,
                Vegetarian = vegetarian,
                CurrentPage = page,
                TotalPages = totalPages
            };

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_DishPartial", viewModel);
            }
            else
            {
                return View(viewModel);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}