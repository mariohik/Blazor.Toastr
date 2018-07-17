using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Blazor.Toastr.Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
                services.AddToastr(new ToastrOptions { closeButton = true, hideDuration = 30000 });
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
