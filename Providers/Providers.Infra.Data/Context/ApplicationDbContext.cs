using Microsoft.EntityFrameworkCore;
using Providers.Domain.Entities;
using Providers.Infra.Data.Mapping;

namespace Providers.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CompanyProviders>()
            .HasDiscriminator<string>("PersonType")
            .HasValue<CompanyProviders>("LegalPerson")
            .HasValue<PhysicalPerson>("PhysicalPerson");
            
            modelBuilder.Entity<CompanyProviders>()
            .HasOne(p => p.Company)
            .WithMany(i => i.CompanyProviders)
            .HasForeignKey(b => b.CompanyId);

            modelBuilder.Entity<PhoneProviders>()
            .HasOne(p => p.CompanyProviders)
            .WithMany(i => i.PhoneProviders)
            .HasForeignKey(b => b.CompanyProvidersId);
            
            modelBuilder.ApplyConfiguration(new PhoneProvidersMap());
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new CompanyProvidersMap());
            modelBuilder.ApplyConfiguration(new PhysicalPersonMap());
            //modelBuilder.ApplyConfiguration(new EntityBaseMap());

            #region Confugura��es
            modelBuilder.Entity<PhoneProviders>().ToTable("PhoneProviders");
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<CompanyProviders>().ToTable("CompanyProviders");
            modelBuilder.Entity<PhysicalPerson>().ToTable("PhysicalPerson");
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        
        #region BdSet
        public DbSet<PhoneProviders> PhoneProviders { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyProviders> CompanyProviders { get; set; }
        public DbSet<PhysicalPerson> PhysicalPerson { get; set; }
        #endregion
    }
}
