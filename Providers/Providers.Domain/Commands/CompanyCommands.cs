using Providers.Domain.Entities;
using Providers.Domain.Enum;
using System.Collections.Generic;

namespace Providers.Domain.Commands
{
    public class CompanyCommands
    {
        public int Id { get; set; }
        public string FantasyName { get; set; }
        public string CNPJ { get; set; }
        public UF UF { get; set; }

        public virtual ICollection<CompanyProvidersCommands> CompanyProviders { get; set; }
    }
}
