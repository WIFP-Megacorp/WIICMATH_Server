using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using WIICMATH_ServerLibrary.Data;
using WIICMATH_ServerLibrary.DbAccess;
using WIICMATH_WebsiteUI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IDeviceData, DeviceData>();
builder.Services.AddSingleton<IDeviceLogData, DeviceLogData>();
builder.Services.AddRadzenComponents();

await builder.Build().RunAsync();

void sqldataaccess()
{
    throw new NotImplementedException();
}