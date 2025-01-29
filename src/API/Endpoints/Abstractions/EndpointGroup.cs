namespace API.Endpoints.Abstractions;

/// <summary>
/// Base class for all endpoint groups.
/// To add new endpoint group, create a new class that inherits from this class and implement the MapEndpoints method.
/// </summary>

public abstract class EndpointGroup
{
    /// <summary>
    /// The name of the endpoint group.
    /// </summary>
    public abstract string Name { get; }

    /// <summary>
    /// Maps all endpoints in the group to the specified route group.
    /// To implement this method inside just call .Map methods
    /// <example>
    /// <code>
    /// group.MapGet("/endpoint", async (HttpContext context) => {});
    /// </code>
    /// </example>
    /// </summary>
    public abstract void MapEndpoints(RouteGroupBuilder group);
    
    public void MapGroup(WebApplication app)
    {
        RouteGroupBuilder group = app.MapGroup(Name);
        MapEndpoints(group);
    }
}