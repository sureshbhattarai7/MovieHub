using MovieManagementSystem.Data.Base;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context): base(context)
        {
            
        }
    }
}
