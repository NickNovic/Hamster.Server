namespace Infrastructure.Models;

public class UserAndContainer
{
    public required User User { get; set; }
    public required Container Container { get; set; }
    public required Role Role { get; set; }
}