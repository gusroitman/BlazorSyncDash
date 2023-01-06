using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using System.Globalization;
using BlazorSync.Shared;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSyncfusionBlazor();
            builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));
           var supportedCultures = new[] { "en-US", "de", "fr", "ar", "zh" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures); 
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkXVpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSH5Rd0RnX3tbeXdcRw==;Mgo+DSMBPh8sVXJ0S0J+XE9Ad1RDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0VhWH5adnBQT2hfUA==;ORg4AjUWIQA/Gnt2VVhkQlFacl5JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRjW35fdHJRQGBcUkU=;ODU3NzM3QDMyMzAyZTM0MmUzMGNCaFBwV21PbGFTb212aTd5cU92Wnl6QTIxWWh0SEhWSU9JMTJ6em51aEU9;ODU3NzM4QDMyMzAyZTM0MmUzMGhyY2JHREk4LzhUVWU3bWNDRGVuTFdpejV5WWdPWmpwVkpBR1RUMkI2dXM9;NRAiBiAaIQQuGjN/V0Z+WE9EaFtDVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViWX1fcXBTQmZcWUN3;ODU3NzQwQDMyMzAyZTM0MmUzMG5ERTlXbFdUcEVtWHZ6ZFNWbUxBaVQxbHZqYVBiK0c3dTJBbkpwQ3AyT2s9;ODU3NzQxQDMyMzAyZTM0MmUzMEx6enJUSHA3eDNGNWNwTlhyb1VvaGkzZjc5NG13Q0lFOEVmMUIzVmZCczg9;Mgo+DSMBMAY9C3t2VVhkQlFacl5JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRjW35fdHJRQGFaVEU=;ODU3NzQzQDMyMzAyZTM0MmUzMFBJcnZ0MUFQSDNzT0plYjRFanVOZmZtNERyV2tYNTdDU245VVYxTGU2WGc9;ODU3NzQ0QDMyMzAyZTM0MmUzMEJxaW1URjl6UUQxRlRZNXpYL1VLbURXK0VrUTJ2dzAvNS8vaXVyMG90UE09;ODU3NzQ1QDMyMzAyZTM0MmUzMG5ERTlXbFdUcEVtWHZ6ZFNWbUxBaVQxbHZqYVBiK0c3dTJBbkpwQ3AyT2s9");

// Configure the HTTP request pipeline.
app.UseRequestLocalization(localizationOptions);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapControllers();
            app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
