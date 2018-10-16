using Providers.Domain.Commands;
using Providers.Domain.Entities;
using Providers.Domain.Repository;
using Providers.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Providers.Infra.Data.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Company>> GetAll()
        {
            var owners = await FindAllAsync();
            return owners.OrderBy(x => x.Id);
        }

        public async Task<Company> GetById(int id)
        {
            var owner = await FindByConditionAync(o => o.Id.Equals(id));
            return owner.DefaultIfEmpty()
                    .FirstOrDefault();
        }


        public async Task<Company> CreateAsync(Company company)
        {
            Create(company);
            await SaveAsync();

            return company;
        }
    }
}
 