using co2unter.API.Infrastructure;
using co2unter.API.Infrastructure.Entities;
using co2unter.API.Interfaces;
using co2unter.API.Models;
using Microsoft.EntityFrameworkCore;

namespace co2unter.API.Repositories;

public class ServiceEmissionsRepository : GenericRepository<ServiceEmission>, IServiceEmissionsRepository
{
    private readonly Co2UnterDbContext _co2UnterDbContext;

    public ServiceEmissionsRepository(Co2UnterDbContext co2UnterDbContext) : base(co2UnterDbContext)
    {
        _co2UnterDbContext = co2UnterDbContext;
    }

    public async Task<List<ServiceEmission>> GetByYearAsync(int year)
    {
        return await _co2UnterDbContext.ServiceEmissions.Where(e => e.Year == year).ToListAsync();
    }

    public async Task<List<int>> GetAvailableYearsAsync()
    {
        return await _co2UnterDbContext.ServiceEmissions.Select(e => e.Year).Distinct().ToListAsync();
    }
}
