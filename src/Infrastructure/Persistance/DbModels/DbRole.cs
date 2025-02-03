namespace Infrastructure.Persistance.DbModels;

public class DbRole
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
}