using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieManagementSystem.Data;
using MovieManagementSystem.Data.Services;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var cinemas = await _service.GetAllAsync();
            return View(cinemas);
        }

        //GET: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("CinemaLogo, CinemaName, Description")] Cinema cinema)
        {
            if(!ModelState.IsValid)
            {
                return View(cinema);
            }

            await _service.AddActorAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        //GET: Cinemas/Details/ID
        public async Task<IActionResult> Details(int id)
        {
            var cinemas = await _service.GetByIdAsync(id);
            if (cinemas == null) return View("NotFound");
            return View(cinemas);
        }
    }
}
