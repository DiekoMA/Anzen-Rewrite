namespace Anzen;

public class Program
{
    public static async Task StartAnzenServer() {
        var builder = WebApplication.CreateBuilder();
        builder.WebHost.UseUrls("http://+:5050");
    }
    public static void Task(string[] args)
    {
        var command = args[0];
        var arguments = args[1];

        Console.WriteLine("Anzen Password Manager");
        Console.WriteLine("Starting API...");
        Console.WriteLine("Running on port 5050");


    }
}
