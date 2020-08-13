using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PWA.Client.Configuration;
using PWA.Infrastructure.Identity;
using System.Threading.Tasks;

namespace PWA.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration _configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Custom service configurations
            services.AddDbContext(_configuration);
            services.AddIdentity();
            services.AddCookieSettings();
            services.AddAccountConfiguration(_configuration);
            services.AddCacheKeys(_configuration);

            // System configurations
            services.AddControllersWithViews();
            services.AddProgressiveWebApp();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, 
            UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            //IdentityContextSeed.SeedData(userManager, roleManager).Wait();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Application/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Application}/{action=Index}/{id?}");
            });
        }
    }
}
