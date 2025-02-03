namespace Infrastructure.Persistance.DbModels;

public class DbContainer
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    //public virtual List<User> Users { get; set; }
}