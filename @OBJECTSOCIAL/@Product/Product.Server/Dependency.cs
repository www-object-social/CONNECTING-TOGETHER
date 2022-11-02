using Microsoft.Extensions.DependencyInjection;

namespace Product.Server;
public static class Dependency
{
    public static void Product(this IServiceCollection SC, Name Name) {
        SC.Product(Name, Environment.Server);
    }
}
