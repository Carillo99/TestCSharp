using Providers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Providers.Domain.Repository
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAll();
        Task<Company> GetById(int id);
        Task<Company> CreateAsync(Company owner);
    }
}
