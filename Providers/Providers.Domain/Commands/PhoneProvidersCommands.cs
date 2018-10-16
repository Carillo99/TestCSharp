using Providers.Domain.Entities;

namespace Providers.Domain.Commands
{
    public class PhoneProvidersCommands
    {
        public int Id { get; set; }
        public int CompanyProvidersId { get; set; }
        public string Phone { get; set; }

        public virtual CompanyProvidersCommands CompanyProviders { get; set; }
    }
}
