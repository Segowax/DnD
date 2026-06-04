using Microsoft.Extensions.DependencyInjection;
using v5.IoC;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.ConfigureV5();

        var serviceProvider = services.BuildServiceProvider();
    }
}