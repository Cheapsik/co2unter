using co2unter.API.Infrastructure;
using co2unter.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace co2unter.CLI;

public class Console : ConsoleAppBase
{
    private readonly ILogger<Console> _logger;
    private readonly Co2UnterDbContext _dbContext;

    public Console(
        ILogger<Console> logger,
        Co2UnterDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [Command("seed-all")]
    public async Task SeedAll()
    {
        List<ServiceEmission> serviceEmissions = await _dbContext.ServiceEmissions.ToListAsync();
        _dbContext.RemoveRange(serviceEmissions);
        await _dbContext.AddRangeAsync(SeedData.ServiceEmissions);

        List<TransportEmission> transportEmissions = await _dbContext.TransportEmissions.ToListAsync();
        _dbContext.RemoveRange(transportEmissions);
        await _dbContext.AddRangeAsync(SeedData.TransportEmissions);

        await _dbContext.SaveChangesAsync();
    }
}