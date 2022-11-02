using Microsoft.Extensions.DependencyInjection;
namespace Product;
/// <summary>
/// Product.
/// </summary>
public static class Dependency
{
    public static void Product(this IServiceCollection SC,Name Name,Environment Environment) => SC.AddScoped(x => new Infomation { Environment = Environment, Name = Name });
}
