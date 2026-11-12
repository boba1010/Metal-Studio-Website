using Metal_Studio.Blazor;
using Metal_Studio.Blazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Octokit;

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
