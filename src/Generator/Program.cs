using Microsoft.Extensions.DependencyInjection;
using v5.Data;
using v5.Data.Domain;
using v5.IoC;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddServicesForV5();

        var serviceProvider = services.BuildServiceProvider();

        var ctx = serviceProvider.GetRequiredService<DnDContext>();

        var lol = ctx.Set<Species>().FirstOrDefault();
        Console.WriteLine(lol?.Name?.ToString() ?? "NULL");
    }
}