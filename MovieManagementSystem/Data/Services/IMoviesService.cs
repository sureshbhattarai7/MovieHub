using MovieManagementSystem.Data.Base;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
    }
}
