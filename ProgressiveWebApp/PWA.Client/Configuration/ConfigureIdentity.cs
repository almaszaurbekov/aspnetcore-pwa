using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PWA.Infrastructure.Identity;
using System;

namespace PWA.Client.Configuration
{
    public static class ConfigureIdentity
    {
        public static void AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 1;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;
            })
            .AddEntityFrameworkStores<IdentityPwaContext>()
            .AddDefaultTokenProviders();
        }
    }
}
