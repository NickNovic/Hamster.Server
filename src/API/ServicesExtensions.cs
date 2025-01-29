using System.Reflection;
using Application;

namespace API;

public static class ServicesExtensions
{
    public static IServiceCollection AddMediatR(this IServiceCollection services)
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetAssembly(typeof(IApplicationMarker))));
        
        return services;
    }
}
