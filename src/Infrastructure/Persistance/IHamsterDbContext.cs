using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance;

public interface IHamsterDbContext
{
    
    public DbSet<IdentityUser> Users { get; set; }
    public Task SaveChangesAsync();
}