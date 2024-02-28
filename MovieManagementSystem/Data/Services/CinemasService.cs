using MovieManagementSystem.Data.Base;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Data.Services
{
    public class CinemasService: EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
            
        }
    }
}
