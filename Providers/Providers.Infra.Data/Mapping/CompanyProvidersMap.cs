using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Providers.Domain.Entities;

namespace Providers.Infra.Data.Mapping
{
    public class CompanyProvidersMap : IEntityTypeConfiguration<CompanyProviders>
    {
        public void Configure(EntityTypeBuilder<CompanyProviders> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.CPF_CNPJ)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.CompanyId)
                .IsRequired();
        }
    }
}
