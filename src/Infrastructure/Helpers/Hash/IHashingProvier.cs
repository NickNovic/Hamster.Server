namespace Infrastructure.Helpers.Hash;
public interface IHashingProvier
{
    public string ComputeHash(object data);    
}