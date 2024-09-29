using co2unter.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace co2unter.API.Infrastructure.EntityConfigurations;

public class DbServiceEmissionEntityTypeConfiguration : IEntityTypeConfiguration<DbServiceEmission>
{
    public void Configure(EntityTypeBuilder<DbServiceEmission> builder)
    {
        builder.HasKey(serviceEmission => new { serviceEmission.ServiceType, serviceEmission.Year });
    }
}
