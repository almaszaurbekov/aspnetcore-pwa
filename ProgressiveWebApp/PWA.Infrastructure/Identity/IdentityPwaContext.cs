using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PWA.Infrastructure.Identity
{
    public sealed class IdentityPwaContext : IdentityDbContext<User>
    {
        public IdentityPwaContext(DbContextOptions<IdentityPwaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
