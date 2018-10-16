using Providers.Domain.Commands;
using Providers.Domain.Entities;
using Providers.Domain.Filter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Providers.Domain.Repository
{
    public interface ICompanyProvidersRepository
    {
        Task<IEnumerable<CompanyProviders>> GetAll(CompanyProvidersQuery CompanyProvidersQuery);
        Task<CompanyProviders> GetByAsync(CompanyProvidersCommands model);
        Task<CompanyProviders> GetById(int id);
        Task<CompanyProviders> CreateAsync(CompanyProviders companyProviders);
    }
}
