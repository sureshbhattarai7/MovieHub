using Microsoft.EntityFrameworkCore;
using MovieManagementSystem.Data.Base;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
       
}
