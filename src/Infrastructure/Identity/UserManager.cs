using Application.Interfaces.Identity;
using Domain.Models;
using Infrastructure.Models;
using Infrastructure.Persistance;
using AutoMapper;

namespace Infrastructure.Identity;
public class UserManager : IUserManager<User, Guid>
{
    private readonly IHamsterDbContext _dbContext;
    public UserManager(IHamsterDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Guid> CreateUserAsync(User user)
    {
        IdentityUser identityUser = IdentityUser.CreateFromUser(user);
        _dbContext.Users.Add(identityUser);

        await _dbContext.SaveChangesAsync();
        
        return user.Id;
    }
    public Task DeleteUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
    public Task<User> GetUserByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }
    public Task<User> GetUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}