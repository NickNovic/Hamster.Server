using MediatR;

namespace Application.UseCases.Commands.Auth.Register;

public class RegisterCommand : IRequest
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}