using System.Reflection;
using Application;

namespace API;

public static class ServicesExtensions
{
    public static void AddMediatR(this IServiceCollection services)
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetAssembly(typeof(IApplicationMarker))));
    }
}
