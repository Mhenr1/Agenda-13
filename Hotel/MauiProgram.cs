using Microsoft.Extensions.Logging;

namespace Hotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(static fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("LobsterTwo-Regular.ttf", "Lobster");
                    fonts.AddFont("PlayfairDisplay-VariableFont_wght.ttf", "Playfair");
                    fonts.AddFont("Parisienne-Regular.ttf", "Parisienne");



                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
