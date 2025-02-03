using Application.Common;
using Domain.Models;

namespace Application.Interfaces.Identity;

public interface IUserManager
{
    public Task<Result<Guid>> CreateUserAsync(User user);
    public Task<Result<User>> GetUserByIdAsync(Guid id);
    public Task<Result<User>> GetUserByEmailAsync(string email);
    public Task<Result<object>> DeleteUserByIdAsync(Guid id);
}