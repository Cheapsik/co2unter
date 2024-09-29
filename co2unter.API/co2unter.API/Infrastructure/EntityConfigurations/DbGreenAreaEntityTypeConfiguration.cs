using co2unter.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace co2unter.API.Infrastructure.EntityConfigurations
{
    public class DbGreenAreaEntityTypeConfiguration : IEntityTypeConfiguration<DbGreenArea>
    {
        public void Configure(EntityTypeBuilder<DbGreenArea> builder)
        {
            builder.HasKey(greenArea => greenArea.Id);
        }
    }
}
