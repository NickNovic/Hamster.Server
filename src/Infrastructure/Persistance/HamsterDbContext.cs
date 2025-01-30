using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance;

public class HamsterDbContext : DbContext, IHamsterDbContext
{
    public DbSet<User> Users { get; set; }

    public Task SaveChangesAsync()
    {
        return this.SaveChangesAsync();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HamsterDb;Username=postgres;Password=");
    }
}