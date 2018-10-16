using Providers.Domain.Enum;
using System.Collections.Generic;

namespace Providers.Domain.Entities
{
    public class Company : EntityBase
    {
        protected Company()
        {
            CompanyProviders = new HashSet<CompanyProviders>();
        }

        public Company(string FantasyName, string CNPJ, UF UF)
        {
            this.FantasyName = FantasyName;
            this.CNPJ = CNPJ;
            this.UF = UF;
        }

        public string FantasyName { get; protected set; }
        public string CNPJ { get; protected set; }
        public UF UF { get; protected set; }

        public virtual ICollection<CompanyProviders> CompanyProviders { get; protected set; }

        public static bool IsObjectNull(Company company)
        {
            return company == null;
        }
    }
}
