using Providers.Domain.Commands;
using Providers.Domain.Entities;
using Providers.Domain.Repository;
using Providers.Infra.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Providers.Tests.Service
{
    /*
    public class CompanyService : Repository<Company>, ICompanyRepository
    {
        private readonly List<Task<CompanyCommands>> _company;

        public CompanyService( )
        {
            _company = new List<CompanyCommands>()
            {
                new CompanyCommands() { Id = 25, FantasyName = "Josué Cabeçote", CNPJ = "989839589353", UF = },
                new CompanyCommands() { Id = 26, FantasyName = "Josué Cabeçote", CNPJ = "989839589353", UF = 1},
                new CompanyCommands() { Id = 27, FantasyName = "Josué Cabeçote", CNPJ = "989839589353", UF = 1}
            };
        }

        public Task<IEnumerable<CompanyCommands>> GetAll()
        {
            return  _company;
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
    }*/
}
