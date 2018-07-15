using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Toastr
{
    public static class ServiceCollectionExtensions
    {
        public static void AddToastr(this IServiceCollection services)
        {
            services.AddSingleton<IToastrService>(new ToastrService());
        }
    }
}
