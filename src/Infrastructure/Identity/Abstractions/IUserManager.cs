using Infrastructure.Models.Abstractions;

namespace Infrastructure.Identity.Abstractions;

public interface IUserManager<TUser, TKey> where TUser : IUser<TKey>
{
    public Task<TKey> CreateUserAsync(TUser user);
    public Task<TUser> GetUserByIdAsync(TKey id);
    public Task<TUser> GetUserByEmailAsync(string email);
    public Task DeleteUserByIdAsync(TKey id);
}