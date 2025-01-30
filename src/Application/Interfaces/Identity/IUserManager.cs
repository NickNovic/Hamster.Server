using Domain.Models.Abstractions;

namespace Application.Interfaces.Identity;

public interface IUserManager<TUser, TKey> where TUser : IUser<TKey>
{
    public Task<TKey> CreateUserAsync(TUser user);
    public Task<TUser> GetUserByIdAsync(TKey id);
    public Task<TUser> GetUserByEmailAsync(string email);
    public Task DeleteUserByIdAsync(TKey id);
}