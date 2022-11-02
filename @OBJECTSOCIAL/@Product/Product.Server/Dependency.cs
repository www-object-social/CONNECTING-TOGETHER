using Microsoft.Extensions.DependencyInjection;
namespace Product.Server;
/// <summary>
/// Should only be used if Environment is Server
/// </summary>
public static class Dependency
{
    public static void Product(this IServiceCollection SC, Name Name) {
        SC.Product(Name, Environment.Server);
    }
}
