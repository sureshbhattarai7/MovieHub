using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using MovieManagementSystem.Data;
using MovieManagementSystem.Data.Cart;
using MovieManagementSystem.Data.Services;
using MovieManagementSystem.Data.ViewModels;

namespace MovieManagementSystem.Controllers
{
    public class OrdersController : Controller
    {
        public readonly IMoviesService _service;
        public readonly ShoppingCart _shoppingCart;
        private readonly IOrdersService _ordersService;

        public OrdersController(IMoviesService service, ShoppingCart shoppingCart, IOrdersService ordersService)
        {
            _service = service;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
        }

        public IActionResult ShoppingCart()
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

        public async Task<RedirectToActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _service.GetByIdAsync(id);

            if(item!=null)
            {
                _shoppingCart.AddItemToCart(item);
            }

            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _service.GetByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);
            }

            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = "";
            string email = "";

            await _ordersService.StoreOrderAsync(items, userId, email);
            await _shoppingCart.ClearShoppingCartAsync();
            return View("OrderCompleted");
        }
    }
}
