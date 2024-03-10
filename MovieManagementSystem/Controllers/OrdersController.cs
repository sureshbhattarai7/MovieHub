using Microsoft.AspNetCore.Mvc;
using MovieManagementSystem.Data.Cart;
using MovieManagementSystem.Data.Services;
using MovieManagementSystem.Data.ViewModels;

namespace MovieManagementSystem.Controllers
{
    public class OrdersController : Controller
    {
        public readonly IMoviesService _service;
        public readonly ShoppingCart _shoppingCart;

        public OrdersController(IMoviesService service, ShoppingCart shoppingCart)
        {
            _service = service;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }
    }
}
