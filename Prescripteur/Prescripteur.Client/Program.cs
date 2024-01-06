using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register the Telerik services.
builder.Services.AddTelerikBlazor();

await builder.Build().RunAsync();
