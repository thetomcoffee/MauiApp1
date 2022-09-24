using MauiApp1.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace MauiApp1;

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

		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

		//AddSingleton like creating a global
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

		//AddTransient like create a temporary page that is created and destroyed as needed.  
		//Should help with memory resources.  
        builder.Services.AddTransient<DetailPage>();
        builder.Services.AddTransient<DetailViewModel>();

        return builder.Build();
	}
}
