using Providers.Domain.Enum;
using System;

namespace Providers.Domain.Entities
{
    public class PhysicalPerson : CompanyProviders
    {
        protected PhysicalPerson() { }

        public PhysicalPerson(string Name, string CPF_CNPJ, bool Ativo, int CompanyId, string DateBirth, string RG, int Age)
        {
            this.Name = Name;
            this.CPF_CNPJ = CPF_CNPJ;
            this.Ativo = Ativo;
            this.CompanyId = CompanyId;
            this.DateBirth = DateBirth;
            this.RG = RG;
            this.Age = Age;
            
            DateRegister = DateTime.Now;
        }

        public string DateBirth { get; protected set; }
        public string RG { get; protected set; }
        public int Age { get; protected set; }

        public bool PrAge(UF uf, int age)
        {
            return (uf == UF.PR) && (age < 18);
        }
    }
}

