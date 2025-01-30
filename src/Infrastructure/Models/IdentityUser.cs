using AutoMapper;
using Domain.Models;
using Mapster;

namespace Infrastructure.Models;

public class IdentityUser : User
{   public required string PasswordHash { get; set; }
    public required List<Device> Devices { get; set; }
    public required List<Container> Containers { get; set; }

    private static readonly IMapper _mapper;
    static IdentityUser()
    {
        _mapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<User, IdentityUser>();
            cfg.CreateMap<IdentityUser, User>();
        }).CreateMapper();
    }
    public static IdentityUser CreateFromUser(User user)
    {        
        IdentityUser identityUser = _mapper.Map<IdentityUser>(user);

        identityUser.PasswordHash = user.Password;

        return identityUser;
    }
}