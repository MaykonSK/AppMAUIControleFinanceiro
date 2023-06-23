using LiteDB;
using MauiApp1.DAO;
using MauiApp1.ViewModel;
using MauiApp1.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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
			})
			.Configurations()
			.RegisterViews();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	public static MauiAppBuilder Configurations(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton<LiteDatabase>(
			options =>
			{
				return new LiteDatabase("Filename="+AppSettings.DatabasePath+";Connection=Shared");
			}
		);

		mauiAppBuilder.Services.AddTransient<ITransacaoDAO, TransacaoDAO>();

        return mauiAppBuilder;

    }

	public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddTransient<TransacaoAddViewModel>();
        mauiAppBuilder.Services.AddSingleton<ITransacaoDAO, TransacaoDAO>();
        return mauiAppBuilder;

	}
}
