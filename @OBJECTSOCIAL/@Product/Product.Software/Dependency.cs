using Product.OS;

namespace Product.Software;
/// <summary>
/// Should only be used if Environment is Software
/// </summary>
public static class Dependency
{
    public static void Product(this IServiceCollection SC, Name Name)
    {
        SC.AddScoped(x => new Infomation { Environment = Environment.Software, Name = Name });
        SC.OS();
    }
}
