using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PWA.Common.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWA.Client.Configuration
{
    public static class ConfigureCacheKeys
    {
        public static void AddCacheKeys(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration
               .GetSection("CacheKeys")
               .Get<CacheKeys>();

            services.AddSingleton(config);
        }
    }
}
