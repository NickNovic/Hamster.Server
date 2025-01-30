using Infrastructure.Models.Abstractions;

namespace Infrastructure.Models;

public class User : IUser<Guid>
{
    public required Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required List<Device> Devices { get; set; }
    public required List<Container> Containers { get; set; }
}