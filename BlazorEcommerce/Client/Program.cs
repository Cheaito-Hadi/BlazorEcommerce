using BlazorEcommerce.Client;
<<<<<<< HEAD
=======
using BlazorEcommerce.Client.Services.ProductService;
>>>>>>> parent of 7d1ac97 (Every thing before Product Variants)
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
<<<<<<< HEAD
=======
builder.Services.AddScoped<IProductService, ProductService>();
>>>>>>> parent of 7d1ac97 (Every thing before Product Variants)

await builder.Build().RunAsync();
