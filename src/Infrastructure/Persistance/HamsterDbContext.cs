using Infrastructure.Persistance.DbModels;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Options;
using Microsoft.Extensions.Options;

namespace Infrastructure.Persistance;

public class HamsterDbContext : DbContext, IHamsterDbContext
{
    public DbSet<DbUser> Users { get; set; }
    public DbSet<DbContainer> Containers { get; set; }
    public DbSet<DbDevice> Devices { get; set; }

    private readonly HamsterDbContextOptions _dbContextOptions;

    public HamsterDbContext(IOptions<HamsterDbContextOptions> dbContextOptions)
    {
        _dbContextOptions = dbContextOptions.Value;
    }
    public Task SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_dbContextOptions.ConnectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DbUser>().ToTable("Users");
    }
}