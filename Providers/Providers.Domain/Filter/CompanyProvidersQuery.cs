using System;

namespace Providers.Domain.Filter
{
    public class CompanyProvidersQuery
    {

        public string Name { get; set; }
        public string CPF_CNPJ { get; set; }
        public string RG { get; set; }
        public DateTime? DateRegister { get; set; }
    }
}
