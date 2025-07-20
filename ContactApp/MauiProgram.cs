using ContactApp;
using ContactApp.ViewModels;
using Microsoft.Extensions.Logging;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Register shared ViewModel
        builder.Services.AddSingleton<MainViewModel>();

        // Register pages
        builder.Services.AddSingleton<AddContactPage>();
        builder.Services.AddSingleton<ContactsPage>();
        builder.Services.AddTransient<ContactsDetailsPage>();

        return builder.Build();
    }
}
