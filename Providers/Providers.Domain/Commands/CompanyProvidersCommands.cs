using Providers.Domain.Entities;
using Providers.Domain.Enum;
using System.Collections.Generic;

namespace Providers.Domain.Commands
{
    public class CompanyProvidersCommands
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF_CNPJ { get; set; }
        public bool Ativo { get; set; }
        public int CompanyId { get; set; }
        public string DateBirth { get; set; }
        public string RG { get; set; }
        public int Age { get; set; }


        public virtual ICollection<PhoneProvidersCommands> PhoneProviders { get; set; }
        public virtual CompanyCommands Company { get; set; }
    }
}
