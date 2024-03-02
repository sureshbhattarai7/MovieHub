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

        //GET: Cinemas/Edit/ID
        public async Task<IActionResult> Edit(int id)
        {
            var cinemas = await _service.GetByIdAsync(id);
            if (cinemas == null) return View("NotFound");
            return View(cinemas);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }

            if (id == cinema.Id)
            {
                await _service.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(Index));
            }
            return View(cinema);
        }

        //GET: Cinemas/Delete/ID
        public async Task<IActionResult> Delete(int id)
        {
            var cinemas = await _service.GetByIdAsync(id);
            if (cinemas == null) return View("NotFound");
            return View(cinemas);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if(!ModelState.IsValid)
            {
                return View(id);
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
