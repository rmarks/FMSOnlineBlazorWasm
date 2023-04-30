using FMS.Client;
using FMS.Client.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

builder.Services.AddSingleton<CompanyRepository>();

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
if (builder.HostEnvironment.IsProduction())
{
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://fmsonlineapi.azurewebsites.net") });
}
else
{
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7272") });
}

Console.WriteLine($"Current Environment: {builder.HostEnvironment.Environment}");

await builder.Build().RunAsync();
