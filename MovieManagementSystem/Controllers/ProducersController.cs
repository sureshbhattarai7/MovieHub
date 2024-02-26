using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieManagementSystem.Data;
using MovieManagementSystem.Data.Services;

namespace MovieManagementSystem.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var producers = await _service.GetAllAsync();
            return View(producers);
        }

        //GET: Producers/Details/ID
        public async Task<IActionResult> Details(int id)
        {
            var producers = await _service.GetByIdAsync(id);
            if (producers == null) return View("NotFound");
            return View(producers);
        }
    }
}
