using API.Endpoints.Abstractions;
using API.Endpoints.Auth.Dtos;
using MediatR;
using Application.UseCases.Commands.Auth.Register;
using Microsoft.AspNetCore.Mvc;

namespace API.Endpoints.Auth;

public class AuthGroup : EndpointGroup
{
    public override string Name => "Auth";
    // private readonly IMediator _mediator;
    // public AuthGroup([FromServices]IMediator mediator)
    // {
    //     _mediator = mediator;
    // }

    public override void MapEndpoints(RouteGroupBuilder group)
    {
        group.MapPost("/login", async (HttpContext context) =>
        {
            await Task.CompletedTask;
        });
        group.MapPost("/register", async (RegisterDto dto,IMediator _mediator) =>
        {
            await _mediator.Send(new RegisterCommand
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Password = dto.Password
            });
        });
    }   
}