using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Providers.Domain.Repository;
using Providers.Infra.Data.Repository;
using Providers.LoggerService;

namespace Providers.Infra.CrossCutting
{
    public static class Bootsrapper
    {
        public static void Ioc(this IServiceCollection services, IConfiguration configuration)
        {
            #region Repositorio
            LoadRepository(services, configuration);
            #endregion

            #region Repositorio
            ConfigureLoggerService(services);
            #endregion
        }

        private static void LoadRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPhoneProvidersRepository, PhoneProvidersRepository>();
            services.AddTransient<ICompanyProvidersRepository, CompanyProvidersRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
