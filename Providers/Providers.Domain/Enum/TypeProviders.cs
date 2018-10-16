using System.ComponentModel;

namespace Providers.Domain.Enum
{
    public enum TypeProviders
    {
        [Description("CPF")]
        CPF = 1,
        [Description("CNPJ")]
        CNPJ = 2
    }
}
