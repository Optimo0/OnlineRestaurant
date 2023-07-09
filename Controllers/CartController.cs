using Microsoft.AspNetCore.Mvc;
using OnlineRestaurant.Interfaces;
using OnlineRestaurant.Models;

namespace OnlineRestaurant.Controllers
{
    public class CartController : Controller
    {
        private readonly IMenuService _menuService;

        public CartController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public IActionResult Index()
        {
            List<CartModel> cartItems = _menuService.GetCartItems();
            decimal totalPrice = _menuService.GetTotalPrice();
            ViewBag.TotalPrice = totalPrice;
            return View(cartItems);
        }

        [HttpPost]
        public IActionResult AddToCart(int dishId)
        {
            _menuService.AddToCart(dishId);
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int dishId)
        {
            _menuService.RemoveFromCart(dishId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateCartItemQuantity(int dishId, int quantity)
        {
            _menuService.UpdateCartItemQuantity(dishId, quantity);
            return RedirectToAction("Index");
        }
    }
}