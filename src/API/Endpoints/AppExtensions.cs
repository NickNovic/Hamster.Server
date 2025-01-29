using System.Reflection;
using API.Endpoints.Abstractions;

namespace API.Endpoints;

public static class AppExtensions
{
    public static void MapEndpoints(this WebApplication app)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        List<Type> endpointTypes = assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(EndpointGroup))).ToList();
        foreach (Type endpointType in endpointTypes)
        {
            EndpointGroup endpointGroup = (EndpointGroup)Activator.CreateInstance(endpointType);
            endpointGroup.MapGroup(app);
        }
    }
}