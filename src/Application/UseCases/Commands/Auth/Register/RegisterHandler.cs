using Application.Interfaces.Identity;
using Domain.Models;
using MediatR;

namespace Application.UseCases.Commands.Auth.Register;

public class RegisterHandler : IRequestHandler<RegisterCommand>
{
    private readonly IUserManager<User, Guid> _userManager;
    public RegisterHandler(IUserManager<User, Guid> userManager)
    {
        _userManager = userManager;
    }
    
    public async Task Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        User user = new User{
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Password = request.Password
        };
        
        await _userManager.CreateUserAsync(user);

//        return user.Id;
    }
}