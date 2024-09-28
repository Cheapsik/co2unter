using co2unter.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace co2unter.API.Infrastructure.EntityConfigurations;

public class DbMassEventEntityTypeConfiguration : IEntityTypeConfiguration<DbMassEvent>
{
    public void Configure(EntityTypeBuilder<DbMassEvent> builder)
    {
        builder.HasKey(bbMassEvent => new { bbMassEvent.Id });
        builder
            .Property(e => e.EventDate)
            .HasConversion(
                v => v.UtcDateTime,
                v => new DateTimeOffset(DateTime.SpecifyKind(v, DateTimeKind.Utc))
        );
    }
}
