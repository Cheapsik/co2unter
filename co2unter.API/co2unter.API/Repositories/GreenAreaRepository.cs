using co2unter.API.Infrastructure;
using co2unter.API.Interfaces;
using co2unter.API.Models;

namespace co2unter.API.Repositories
{
    public class GreenAreaRepository : GenericRepository<GreenArea>, IGreenAreaRepository
    {
        private readonly Co2UnterDbContext _co2UnterDbContext;

        public GreenAreaRepository(Co2UnterDbContext co2UnterDbContext) : base(co2UnterDbContext)
        {
            _co2UnterDbContext = co2UnterDbContext;
        }
    }
}
