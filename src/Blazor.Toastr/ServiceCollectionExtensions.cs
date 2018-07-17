using Microsoft.Extensions.DependencyInjection;

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
    }
}
