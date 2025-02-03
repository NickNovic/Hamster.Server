namespace Infrastructure.Persistance.DbModels;

public class DbDevice
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
}