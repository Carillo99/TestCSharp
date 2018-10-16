using Providers.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Providers.Domain.Repository
{
    public interface IPhoneProvidersRepository
    {
        Task<PhoneProviders> CreateAsync(PhoneProviders owner);
    }
}
