using CommunityToolkit.Maui;

namespace ELearningMobieApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Gilroy-Bold.ttf", "GilroyBold");
				fonts.AddFont("Gilroy-Regular.ttf", "GilroyRegular");
                fonts.AddFont("Gilroy-Medium.ttf", "GilroyMedium");
				fonts.AddFont("MaterialIconsRound-Regular.otf", "MaterialRound");
				fonts.AddFont("MaterialIconsOutlined-Regular.otf", "MaterialOutline");
                fonts.AddFont("icomoon.ttf", "ICO");
				fonts.AddFont("materialdesignicons-webfont.ttf", "MDI");
            });

		return builder.Build();
	}
}

