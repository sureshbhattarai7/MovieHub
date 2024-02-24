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
            var actors = await _services.GetAllAsync();
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

            await _services.AddActorAsync(actor);
            return RedirectToAction("Index");
        }

        //GET Actor: Actor/Details/ID
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _services.GetByIdAsync(id);
            if (actorDetails==null) return View("NotFound");
            return View(actorDetails);
        }

        //Edit Actor
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _services.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ActorId, ProfilePictureUrl, FullName, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _services.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //Delete Actor
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _services.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _services.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
           

            await _services.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
