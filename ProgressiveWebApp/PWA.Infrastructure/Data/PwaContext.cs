using Microsoft.EntityFrameworkCore;
using PWA.Infrastructure.Entities;

namespace PWA.Infrastructure.Data
{
    public class PwaContext : DbContext
    {
        public PwaContext(DbContextOptions<PwaContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PwaContextSeed.Initialize(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
