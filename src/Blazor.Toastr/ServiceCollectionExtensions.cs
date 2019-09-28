using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace Blazor.Toastr
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddToastr(this IServiceCollection services, ToastrOptions options)
        {
            services.AddSingleton<IToastrService>(new ToastrService(options));
            return services;
        }

        public static IServiceCollection AddToastr(this IServiceCollection services)
        {
            services.AddSingleton<IToastrService>(new ToastrService());
            return services;
        }

        public static IBlazorApplicationBuilder UseToastr(this IBlazorApplicationBuilder app)
        {
            Interop.JsRuntime = app.Services.GetService<IJSRuntime>();
            return app;
        }
    }
}
