using co2unter.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace co2unter.API.Infrastructure.EntityConfigurations;

public class DbTransportEmissionEntityTypeConfiguration : IEntityTypeConfiguration<DbTransportEmission>
{
    public void Configure(EntityTypeBuilder<DbTransportEmission> builder)
    {
        builder.HasKey(transportEmission => new { transportEmission.TransportType, transportEmission.Year });
    }
}
