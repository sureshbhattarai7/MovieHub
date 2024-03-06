using MovieManagementSystem.Data.Base;
using MovieManagementSystem.Data.ViewModels;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync (NewMovieVM data);
    }
}
