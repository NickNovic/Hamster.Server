using Domain.Models;

namespace Application.Interfaces.Identity;

public interface IUserManager
{
    public Task<Guid> CreateUserAsync(User user);
    public Task<User> GetUserByIdAsync(Guid id);
    public Task<User> GetUserByEmailAsync(string email);
    public Task DeleteUserByIdAsync(Guid id);
}