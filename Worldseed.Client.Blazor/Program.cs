using Blazored.LocalStorage;
using BlazorStrap;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Worldseed.Client.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiUrl = builder.Configuration["ApiBaseUrl"] ?? builder.HostEnvironment.BaseAddress;
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });

builder.Services.AddBlazorStrap();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<Worldseed.Client.Blazor.Services.AuthService>();


await builder.Build().RunAsync();
