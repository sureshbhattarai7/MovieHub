using MovieManagementSystem.Models;

namespace MovieManagementSystem.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void AddActor(Actor actor);
        Actor Update (int id, Actor newActor);
        void Delete(int id);
    }
}
