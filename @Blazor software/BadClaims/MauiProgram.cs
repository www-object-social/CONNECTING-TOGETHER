using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Product.Software;
namespace BadClaims;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        builder.Services.AddMauiBlazorWebView();
        builder.Services.Product(Product.Name.BadClaims);
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}