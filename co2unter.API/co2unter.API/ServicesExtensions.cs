using co2unter.API.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace co2unter.API;

public static class ServicesExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<Co2UnterDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("co2unter.API"));
            options.UseSnakeCaseNamingConvention();
        });

        return services;
    }
}
