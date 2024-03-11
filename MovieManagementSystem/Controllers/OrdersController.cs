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

        public OrdersController(IMoviesService service, ShoppingCart shoppingCart)
        {
            _service = service;
            _shoppingCart = shoppingCart;
        }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = int.Parse(cartId) };
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
