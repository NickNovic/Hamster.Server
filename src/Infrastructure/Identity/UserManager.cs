using Application.Interfaces.Identity;
using Domain.Models;
using Infrastructure.Persistance;
using AutoMapper;
using Infrastructure.Persistance.DbModels;

namespace Infrastructure.Identity;
public class UserManager : IUserManager
{
    private readonly IHamsterDbContext _dbContext;
    private readonly IMapper _mapper;
    public UserManager(IHamsterDbContext dbContext)
    {
        _dbContext = dbContext;
        _mapper = new MapperConfiguration(cfg => 
        {
            cfg.CreateMap<DbUser, User>();
            cfg.CreateMap<User, DbUser>();
        }).CreateMapper();
    }
    public async Task<Guid> CreateUserAsync(User user)
    {
        DbUser dbUser = _mapper.Map<DbUser>(user);
        dbUser.PasswordHash = user.Password;
        
        _dbContext.Users.Add(dbUser);

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