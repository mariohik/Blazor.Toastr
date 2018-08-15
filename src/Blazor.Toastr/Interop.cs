using Blazor.Toastr.Enums;
using Microsoft.JSInterop;

namespace Blazor.Toastr
{
    internal static class Interop
    {
        public static ToastrOptionsInternal toastrOptions;

        public static void ShowToastr(ToastrType toastrType, string message, string title = null)
        {
            switch (toastrType)
            {
                case ToastrType.Success:
                    JSRuntime.Current.InvokeAsync<string>("toastrInterop.success", message, title, Json.Serialize(toastrOptions));
                    break;
                case ToastrType.Info:
                    JSRuntime.Current.InvokeAsync<string>("toastrInterop.info", message, title, Json.Serialize(toastrOptions));
                    break;
                case ToastrType.Warning:
                    JSRuntime.Current.InvokeAsync<string>("toastrInterop.warning", message, title, Json.Serialize(toastrOptions));
                    break;
                case ToastrType.Error:
                    JSRuntime.Current.InvokeAsync<string>("toastrInterop.error", message, title, Json.Serialize(toastrOptions));
                    break;
                default:
                    break;
            }
        }
    }
}
