using Application.Common;
using Application.Interfaces.Identity;
using Domain.Models;
using Application.Interfaces;
using MediatR;

namespace Application.UseCases.Commands.Auth.Login;

public class LoginHandler : IRequestHandler<LoginCommand, Result<string>>
{
    private readonly IUserManager _userManager;
    private readonly IJwtTokenHelper _jwtTokenHelper;
    public LoginHandler(IUserManager userManager , IJwtTokenHelper jwtTokenHelper)
    {
        _userManager = userManager;
        _jwtTokenHelper = jwtTokenHelper;
    }
    public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        Result<User> result = await _userManager.GetUserByEmailAsync(request.Email);
        if(!result.IsSuccess)
        {
            return Result<string>.Fail(result.Error);
        }

        User user = result.Data;

        bool isPasswordCorrect = await _userManager.CheckPasswordAsync(user.Id, request.Password);

        if (!isPasswordCorrect)
        {
            return Result<string>.Fail(Message.InvalidCredentials);
        }

        string token = _jwtTokenHelper.GenerateToken(user);

        return Result<string>.Success(token, Message.Success);
    }
}