using Providers.Domain.Commands;
using Providers.Domain.Entities;
using Providers.Domain.Filter;
using Providers.Domain.Repository;
using Providers.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Providers.Infra.Data.Repository
{
    public class CompanyProvidersRepository : Repository<CompanyProviders>, ICompanyProvidersRepository
    {
        public CompanyProvidersRepository(ApplicationDbContext context) : base(context)
        {}

        public async Task<IEnumerable<CompanyProviders>> GetAll(CompanyProvidersQuery CompanyProvidersQuery)
        {
            var query = await FindAllAsync();

            if (!string.IsNullOrEmpty(CompanyProvidersQuery.Name))
                query = query.Where(v => v.Name == CompanyProvidersQuery.Name);
            
            if (!string.IsNullOrEmpty(CompanyProvidersQuery.CPF_CNPJ))
                query = query.Where(v => v.CPF_CNPJ == CompanyProvidersQuery.CPF_CNPJ);
            
            if (CompanyProvidersQuery.DateRegister != null)
                query = query.Where(v => v.DateRegister == CompanyProvidersQuery.DateRegister);

            return query.OrderBy(x => x.Name);
        }

        public async Task<CompanyProviders> GetById(int id)
        {
            var owner = await FindByConditionAync(o => o.Id.Equals(id));
            return owner.DefaultIfEmpty()
                    .FirstOrDefault();
        }

        public async Task<CompanyProviders> CreateAsync(CompanyProviders companyProviders)
        {
            base.Create(companyProviders);
            await SaveAsync();
            return companyProviders;
        }

        public async Task<CompanyProviders> GetByAsync(CompanyProvidersCommands model)
        {
            var owner = await FindByConditionAync(o => o.CPF_CNPJ.Equals(model.CPF_CNPJ));
            return owner.DefaultIfEmpty()
                    .FirstOrDefault();
        }
    }
}
