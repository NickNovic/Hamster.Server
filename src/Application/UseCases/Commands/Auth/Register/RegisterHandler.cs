using Application.Common;
using Application.Interfaces.Identity;
using Domain.Models;
using MediatR;

namespace Application.UseCases.Commands.Auth.Register;

public class RegisterHandler : IRequestHandler<RegisterCommand, Result<Guid>>
{
    private readonly IUserManager _userManager;
    public RegisterHandler(IUserManager userManager)
    {
        _userManager = userManager;
    }
    
    public async Task<Result<Guid>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        User user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Password = request.Password
        };
        
        Result<Guid> result = await _userManager.CreateUserAsync(user);

        return result;
    }
}