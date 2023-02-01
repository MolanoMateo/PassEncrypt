using ProyectoPassword.View;
using ProyectoPassword.ViewModel;

namespace ProyectoPassword;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<PassPageViewModel>();
        builder.Services.AddSingleton<NewPassViewModel>();
        return builder.Build();
	}
}
