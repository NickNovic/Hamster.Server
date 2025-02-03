using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Helpers.Hash;

public class Sha256HasingProvider : IHashingProvier
{
    public string ComputeHash(object data)
    {
        using SHA256 sha256Hash = SHA256.Create();
        byte[] dataBytes = Encoding.UTF8.GetBytes(data.ToString());
        byte[] hashBytes = sha256Hash.ComputeHash(dataBytes);

        return Convert.ToBase64String(hashBytes);
    }
}