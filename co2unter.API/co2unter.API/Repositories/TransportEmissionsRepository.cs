using co2unter.API.Infrastructure;
using co2unter.API.Infrastructure.Entities;
using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.EntityFrameworkCore;

namespace co2unter.API.Repositories;

public class TransportEmissionsRepository : GenericRepository<DbTransportEmission>, ITransportEmissionsRepository
{
    private readonly Co2UnterDbContext _co2UnterDbContext;

    public TransportEmissionsRepository(Co2UnterDbContext co2UnterDbContext) : base(co2UnterDbContext)
    {
        _co2UnterDbContext = co2UnterDbContext;
    }

    public async Task<List<DbTransportEmission>> GetByYearAsync(int year)
    {
        return await _co2UnterDbContext.TransportEmissions.Where(e => e.Year == year).ToListAsync();
    }

    public async Task<List<int>> GetAvailableYearsAsync()
    {
        return await _co2UnterDbContext.TransportEmissions.Select(e => e.Year).Distinct().ToListAsync();
    }
}
