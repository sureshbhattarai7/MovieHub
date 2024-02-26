using MovieManagementSystem.Data.Base;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context): base(context)
        {
            
        }
    }
}
