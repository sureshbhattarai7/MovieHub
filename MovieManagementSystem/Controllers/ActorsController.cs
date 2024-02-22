using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieManagementSystem.Data;
using MovieManagementSystem.Data.Services;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _services;

        public ActorsController(IActorsService services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var actors = await _services.GetAll();
            return View(actors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }

            _services.AddActor(actor);
            return RedirectToAction("Index");
        }
    }
}
