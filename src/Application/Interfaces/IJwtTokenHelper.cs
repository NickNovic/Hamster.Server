using Domain.Models;

namespace Application.Interfaces;

public interface IJwtTokenHelper
{
    public string GenerateToken(User user);
}