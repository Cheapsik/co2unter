using co2unter.API.Infrastructure.Entities;
using co2unter.API.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace co2unter.API.Infrastructure;

public class Co2UnterDbContext : DbContext
{
    public DbSet<ServiceEmission> ServiceEmissions { get; set; }
    public DbSet<TransportEmission> TransportEmissions { get; set; }

    public Co2UnterDbContext() { }

    public Co2UnterDbContext(DbContextOptions<Co2UnterDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ServiceEmissionEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new TransportEmissionEntityTypeConfiguration());
    }
}
