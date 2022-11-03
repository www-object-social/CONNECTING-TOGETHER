using Microsoft.Extensions.DependencyInjection;
namespace Product.Browser;
/// <summary>
/// Should only be used if Environment is Browser
/// </summary>
public static class Dependency
{
    public static void Product(this IServiceCollection SC, Name Name) {
        SC.AddScoped(x => new Infomation { Environment = Environment.Browser, Name = Name });
    }
}
