using KirdevServer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace KirdevServer.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).IsRequired();
                entity.Property(e => e.Username).IsRequired().HasMaxLength(20);
                entity.Property(e => e.PasswordHash).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.Birthday).IsRequired();
                entity.Property(e => e.Registred).IsRequired();
            });
        }
    }
}
