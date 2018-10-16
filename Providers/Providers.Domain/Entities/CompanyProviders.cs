using System;
using System.Collections.Generic;

namespace Providers.Domain.Entities
{
    public class CompanyProviders : EntityBase
    {
        protected CompanyProviders()
        {
            PhoneProviders = new HashSet<PhoneProviders>();
        }

        public CompanyProviders(string Name, string CPF_CNPJ, bool Ativo, int CompanyId)
        {
            this.Name = Name;
            this.CPF_CNPJ = CPF_CNPJ;
            this.Ativo = Ativo;
            this.CompanyId = CompanyId;
            
            DateRegister = DateTime.Now;
        }

        public string Name { get; protected set; }
        public string CPF_CNPJ { get; protected set; }
        public DateTime DateRegister { get; protected set; }
        public bool Ativo { get; protected set; }
        public int CompanyId { get; protected set; }

        public virtual Company Company { get; protected set; }
        public virtual ICollection<PhoneProviders> PhoneProviders { get; protected set; }
        
    }
}
