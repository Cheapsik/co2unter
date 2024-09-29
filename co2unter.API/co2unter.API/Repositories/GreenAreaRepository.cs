using co2unter.API.Infrastructure;
using co2unter.API.Interfaces;
using co2unter.API.Models;

namespace co2unter.API.Repositories
{
    public class GreenAreaRepository : IGreenAreaRepository
    {
        private readonly Co2UnterDbContext _co2UnterDbContext;

        public GreenAreaRepository(Co2UnterDbContext co2UnterDbContext)
        {
            _co2UnterDbContext = co2UnterDbContext;
        }

        public Task AddAsync(GreenArea entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GreenArea>> GetAllAsync()
        {
            return _co2UnterDbContext.GreenAreas.Select(ga => ga.Map()).ToList();
        }

        public Task RemoveAsync(GreenArea entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(GreenArea entity)
        {
            throw new NotImplementedException();
        }
    }
}
