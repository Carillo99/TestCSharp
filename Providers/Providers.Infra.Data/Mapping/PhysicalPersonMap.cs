using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Providers.Domain.Entities;

namespace Providers.Infra.Data.Mapping
{
    public class PhysicalPersonMap : IEntityTypeConfiguration<PhysicalPerson>
    {
        public void Configure(EntityTypeBuilder<PhysicalPerson> builder)
        {
            builder.Property(c => c.Age)
                .IsRequired();

            builder.Property(c => c.RG)
                .IsRequired();

            builder.Property(c => c.DateBirth)
                .IsRequired();
        }
    }
}
