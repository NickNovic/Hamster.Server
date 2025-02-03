using Application.Interfaces.Identity;
using Domain.Models;
using Infrastructure.Persistance;
using AutoMapper;
using Infrastructure.Persistance.DbModels;
using Microsoft.EntityFrameworkCore;
using Application.Common;
using System.Security.Cryptography;
using Infrastructure.Helpers.Hash;

namespace Infrastructure.Identity;
public class UserManager : IUserManager
{
    private readonly IHamsterDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IHashingProvier _hashingProvier;
    public UserManager(IHamsterDbContext dbContext, IHashingProvier hashingProvier)
    {
        _dbContext = dbContext;
        _mapper = new MapperConfiguration(cfg => 
        {
            cfg.CreateMap<DbUser, User>();
            cfg.CreateMap<User, DbUser>();
        }).CreateMapper();
        _hashingProvier = hashingProvier;
    }
    public async Task<Result<Guid>> CreateUserAsync(User user)
    {
        DbUser emailUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
        if (emailUser is not null)
        {
            return Result<Guid>.Fail(Message.UserAlreadyExists);
        }

        DbUser dbUser = _mapper.Map<DbUser>(user);
        dbUser.PasswordHash = _hashingProvier.ComputeHash(user.Password);

        _dbContext.Users.Add(dbUser);

        await _dbContext.SaveChangesAsync();
        
        return Result<Guid>.Success(user.Id);
    }

    public Task<Result<object>> DeleteUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Result<User>> GetUserByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<Result<User>> GetUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}