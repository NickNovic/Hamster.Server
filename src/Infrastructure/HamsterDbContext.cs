using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class HamsterDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HamsterDb;Username=postgres;Password=");
    }
}