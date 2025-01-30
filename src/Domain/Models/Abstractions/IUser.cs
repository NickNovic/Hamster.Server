namespace Domain.Models.Abstractions;
public interface IUser<T>
{
    public T Id { get; set; }
    public string Password { get; set; }
}