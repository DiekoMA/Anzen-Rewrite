using System.Net.Http.Headers;
using System.Reflection;
using Anzen.Objects;
namespace Anzen;

public class Program
{
    public static async Task StartAnzenServer()
    {
        var builder = WebApplication.CreateBuilder();
        builder.WebHost.UseUrls("http://+:5050");
        builder.Services.AddHttpClient();
        builder.Logging.ClearProviders();

        var app = builder.Build();

        app.UseStatusCodePages(async context =>
        {
            var response = context.HttpContext.Response;

            if (response.StatusCode == 404)
            {
                response.ContentType = "text/html";
            }
            else if (response.StatusCode == 401)
            {
                response.ContentType = "text/html";
                await response.SendFileAsync("wwwroot/401.html");
            }
        });

        app.MapGet("health", async (HttpRequest req) =>
        {

            var healthyResponse = new HealthResponse
            {
                Name = "Anzen",
                Version = "1.0",
                Healthy = true
            };
            return healthyResponse;
        });

        app.MapGet("passwords", async (HttpRequest req) =>
        {

        });

        app.MapGet("snippets", async (HttpRequest req) =>
        {

        });
        Console.WriteLine("Listening on http://+:5050");
        app.UseDefaultFiles();
        app.UseStaticFiles();
        await app.RunAsync();
    }



    public static async Task Main(string[] args)
    {
        // var command = args[0];
        // var arguments = args[1];

        Console.WriteLine("Anzen Password Manager");
        Console.WriteLine("Starting API...");
        Console.WriteLine("Running on port 5050");

        await StartAnzenServer();
        VaultDB vaultDb = new VaultDB(new ConfigData
        {
            Database = "postgress",
            Host = "localhost",
            Password = "test",
            Port = 4023,
            Username = "postgress"
        });

        vaultDb.CreateTable();

    }
}
