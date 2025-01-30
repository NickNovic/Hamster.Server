using Domain.Models.Abstractions;

namespace Domain.Models;

public class User : IUser<Guid>
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}