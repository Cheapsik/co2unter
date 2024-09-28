using Microsoft.Extensions.Logging;
using co2unter.API;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleAppBuilder builder = ConsoleApp.CreateBuilder(args);

        builder.ConfigureServices((host, services) =>
        {
            services.AddInfrastructure(host.Configuration);
        });

        builder.ConfigureLogging(configureLogging =>
        {
            configureLogging.ClearProviders();
            configureLogging.AddConsole();
            configureLogging.AddDebug();
        });

        ConsoleApp app = builder.Build();

        app.AddCommands<co2unter.CLI.Console>();

        app.Run();
    }
}