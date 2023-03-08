using KomdekaAPI.Entities.Configuration;
using KomdekaAPI.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KomdekaAPI.Entities
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Tool> Tools { get; set; }
    }
}
