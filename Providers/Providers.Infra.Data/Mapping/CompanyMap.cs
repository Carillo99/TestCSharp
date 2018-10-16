using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Providers.Domain.Entities;

namespace Providers.Infra.Data.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(c => c.FantasyName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(c => c.CNPJ)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(c => c.UF)
                .IsRequired();
        }
    }
}
