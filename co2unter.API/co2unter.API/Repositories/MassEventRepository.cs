using co2unter.API.Infrastructure;
using co2unter.API.Infrastructure.Entities;
using co2unter.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace co2unter.API.Repositories;

public class MassEventRepository : GenericRepository<DbMassEvent>, IMassEventRepository
{
    private readonly Co2UnterDbContext _co2UnterDbContext;

    public MassEventRepository(Co2UnterDbContext co2UnterDbContext) : base(co2UnterDbContext)
    {
        _co2UnterDbContext = co2UnterDbContext;
    }

    public async Task<DbMassEvent?> GetMassEventByIdAsync(Guid massEventId)
    {
        return await _co2UnterDbContext.MassEvents.FirstOrDefaultAsync(x => x.Id == massEventId);
    }
}
