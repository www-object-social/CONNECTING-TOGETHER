using Microsoft.Extensions.DependencyInjection;
namespace Product;
/// <summary>
/// Dependency
/// Should only be used if Environment is Software, Browser and Server
/// </summary>
public static class Dependency
{
    public static void Product(this IServiceCollection SC, Name Name, Environment Environment) {
        SC.AddScoped(x => new Infomation { Environment = Environment, Name = Name });
    }
}
