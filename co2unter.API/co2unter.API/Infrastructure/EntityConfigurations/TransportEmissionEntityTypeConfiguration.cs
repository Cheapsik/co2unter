using co2unter.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace co2unter.API.Infrastructure.EntityConfigurations;

public class TransportEmissionEntityTypeConfiguration : IEntityTypeConfiguration<TransportEmission>
{
    public void Configure(EntityTypeBuilder<TransportEmission> builder)
    {
        builder.HasKey(transportEmission => new { transportEmission.TransportType, transportEmission.Year });
    }
}
