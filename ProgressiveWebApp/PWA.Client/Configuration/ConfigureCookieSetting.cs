using Microsoft.Extensions.DependencyInjection;

namespace PWA.Client.Configuration
{
    public static class ConfigureCookieSetting
    {
        public static void AddCookieSettings(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "Identity.Cookie";
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Shared/AccessDenied";
            });
        }
    }
}
