using MauiTest.Services.OpenCv;
using MauiTest.ViewModels;

using Microsoft.Extensions.Logging;

namespace MauiTest
{
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
				.RegisterAppServices()
				.RegisterViewModels()
				.RegisterViews()
				.RegisterModels();
			;

#if DEBUG
    		builder.Logging.AddDebug();
#endif
			return builder.Build();
		}
		private static MauiAppBuilder RegisterAppServices(this MauiAppBuilder builder) {
			builder.Services.AddSingleton<AppShell>();
			builder.Services.AddSingleton<OpenCvService>();

			return builder;
		}

		private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder) {
			builder.Services.AddTransient<MainViewModel>();

			return builder;
		}

		private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder) {
			builder.Services.AddTransient<MainPage>();

			return builder;
		}

		private static MauiAppBuilder RegisterModels(this MauiAppBuilder builder) {
			return builder;
		}
	}
}
