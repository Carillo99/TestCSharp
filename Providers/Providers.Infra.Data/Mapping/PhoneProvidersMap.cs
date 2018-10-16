using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Providers.Domain.Entities;

namespace Providers.Infra.Data.Mapping
{
    public class PhoneProvidersMap : IEntityTypeConfiguration<PhoneProviders>
    {
        public void Configure(EntityTypeBuilder<PhoneProviders> builder)
        {
            builder.Property(c => c.Phone)
                .IsRequired()
                .HasMaxLength(15);
        }
    }
}
