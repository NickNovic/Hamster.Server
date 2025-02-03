using Domain.Models.Abstractions;

namespace Domain.Models;

public class Role : BaseEntity
{
    public required string Name { get; set; }
}