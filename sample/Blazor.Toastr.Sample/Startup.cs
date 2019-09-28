using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Toastr.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add any custom services here
            services.AddToastr(new ToastrOptions { closeButton = true, hideDuration = 30000 });
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.UseToastr();
            app.AddComponent<App>("app");
        }
    }
}
