using Microsoft.Extensions.DependencyInjection;
using v5.IoC;
using v5.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.ConfigureV5();

        var serviceProvider = services.BuildServiceProvider();

        var languagesRepo = serviceProvider.GetRequiredService<ILanguagesRepository>();

        languagesRepo.GetAllAsync().ContinueWith(task =>
        {
            var languages = task.Result;
            foreach (var language in languages)
            {
                Console.WriteLine($"Language: {language.Name}");
            }
        }).Wait();
    }
}