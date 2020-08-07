using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace PWA.Infrastructure.Identity
{
    public sealed class IdentityContextSeed
    {
        public static async Task SeedData(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var roles = new string[] { "Administrator", "User" };

            await SeedRoles(roleManager, roles);
            await SeedUsers(userManager);
        }

        public static async Task SeedUsers(UserManager<User> userManager)
        {
            if (await userManager.FindByNameAsync("foxyAdmin") == null)
            {
                var user = new User() { UserName = "foxyAdmin", Email = "foxychmoxy@admin" };
                var result = await userManager.CreateAsync(user, "admin123!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }


            if (userManager.FindByNameAsync("foxyUser").Result == null)
            {
                var user = new User() { UserName = "foxyUser", Email = "foxychmoxy@user" };
                var result = await userManager.CreateAsync(user, "user123!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User");
                }
            }
        }

        public static async Task SeedRoles(RoleManager<IdentityRole> roleManager, string[] roles)
        {
            foreach (var role in roles)
            {
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
