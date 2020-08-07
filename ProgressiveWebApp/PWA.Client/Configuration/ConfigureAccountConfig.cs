using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PWA.Common.Configurations;

namespace PWA.Client.Configuration
{
    public static class ConfigureAccountConfig
    {
        public static void AddAccountConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var accountConfig = configuration
                .GetSection("AccountConfiguration")
                .Get<AccountConfiguration>();

            services.AddSingleton(accountConfig);
        }
    }
}
