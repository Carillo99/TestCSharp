using Providers.Domain.Entities;
using Providers.Domain.Repository;
using Providers.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Providers.Infra.Data.Repository
{
    public class PhoneProvidersRepository : Repository<PhoneProviders>, IPhoneProvidersRepository
    {
        public PhoneProvidersRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<PhoneProviders> CreateAsync(PhoneProviders phoneProviders)
        {
            Create(phoneProviders);
            await SaveAsync();
            return phoneProviders;
        }
    }
}
