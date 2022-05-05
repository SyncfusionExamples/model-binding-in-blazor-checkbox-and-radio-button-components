using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlazorApp;
using Syncfusion.Blazor;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjA0NzI4QDMyMzAyZTMxMmUzMElnd0owNjFveXpldXBBVW9aQ3BkR2VGQUZRK2doVFZPak92T2VzNm5MR1k9");
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
