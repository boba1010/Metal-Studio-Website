using Metal_Studio.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Octokit;

namespace Metal_Studio;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddSingleton(sp =>
        {
            var client = new GitHubClient(new ProductHeaderValue("Portfolio"));
            return client;
        });

        builder.Services.AddScoped(sp => new HttpClient());
        builder.Services.AddScoped<GitHubStatsService>();

        await builder.Build().RunAsync();
    }
}
