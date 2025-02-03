using Application.Interfaces.Identity;
using Domain.Models;
using Infrastructure.Helpers.Hash;
using Infrastructure.Identity;
using Infrastructure.Persistance;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ServiceExtensions
{
    public static IServiceCollection AddDbContext(this IServiceCollection services)
    {
        services.AddDbContext<HamsterDbContext>();
        services.AddScoped<IHamsterDbContext, HamsterDbContext>();
        return services;
    }
    public static IServiceCollection AddIdentity(this IServiceCollection services)
    {
        services.AddScoped<IUserManager, UserManager>();
        services.AddScoped<IHashingProvier, Sha256HasingProvider>();

        return services;
    }
}