namespace Infrastructure.Models.Abstractions;
public interface IUser<T>
{
    public T Id { get; set; }
}