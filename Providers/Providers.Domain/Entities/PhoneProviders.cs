namespace Providers.Domain.Entities
{
    public class PhoneProviders : EntityBase
    {
        protected PhoneProviders() { }

        public PhoneProviders( string Phone, int CompanyProvidersId)
        {
            this.CompanyProvidersId = CompanyProvidersId;
            this.Phone = Phone;
        }

        public string Phone { get; protected set; }
        public int CompanyProvidersId { get; protected set; }

        public virtual CompanyProviders CompanyProviders { get; protected set; }
    }
}