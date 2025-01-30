using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance;

public class HamsterDbContext : DbContext, IHamsterDbContext
{
    public DbSet<IdentityUser> Users { get; set; }

    public Task SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HamsterDb;Username=postgres;Password=");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<IdentityUser>().ToTable("Users");
        modelBuilder.Entity<IdentityUser>().Ignore(c => c.Password);
    }
}