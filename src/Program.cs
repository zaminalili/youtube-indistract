using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using youtube_indistract;
using youtube_indistract.Services.Abstract;
using youtube_indistract.Services.Concrete;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.googleapis.com/youtube/v3/") });

builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();

builder.Services.AddScoped<IYoutubeApiService, YoutubeApiService>();

await builder.Build().RunAsync();
