using Microsoft.AspNetCore.Mvc;
using OnlineRestaurant.Models;
using System.Diagnostics;
using OnlineRestaurant.Services;
using OnlineRestaurant.Interfaces;

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

        public ActionResult Index(string category, int? spiciness, bool? containsNuts, bool? vegetarian)
        {
            List<DishModel> dishes = _menuService.GetFilteredDishes(category, spiciness, containsNuts, vegetarian);
            return View(dishes);
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