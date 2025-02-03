using Infrastructure.Persistance.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance;

public interface IHamsterDbContext
{
    public DbSet<DbContainer> Containers { get; set; }
    public DbSet<DbDevice> Devices { get; set; }
    public DbSet<DbUser> Users { get; set; }
    public Task SaveChangesAsync();
}