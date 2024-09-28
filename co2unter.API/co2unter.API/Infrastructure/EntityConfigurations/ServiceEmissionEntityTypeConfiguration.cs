using co2unter.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace co2unter.API.Infrastructure.EntityConfigurations;

public class ServiceEmissionEntityTypeConfiguration : IEntityTypeConfiguration<ServiceEmission>
{
    public void Configure(EntityTypeBuilder<ServiceEmission> builder)
    {
        builder.HasKey(serviceEmission => new { serviceEmission.ServiceType, serviceEmission.Year });
    }
}
