using Application.Common;
using MediatR;

namespace Application.UseCases.Commands.Auth.Login;

public class LoginCommand : IRequest<Result<string>>
{
    public required string Email { get; set; }
    public required string Password { get; set; }
}