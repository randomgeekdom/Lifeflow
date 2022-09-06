using Lifeflow.Services;

namespace Lifeflow;

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

		// Base services
        builder.Services.AddTransient<IFileSaver, FileSaver>();

		// UI services
        builder.Services.AddTransient<IFlowEditor, FlowEditor>();

        // UI Pages
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<EditPage>();

        return builder.Build();
	}
}
