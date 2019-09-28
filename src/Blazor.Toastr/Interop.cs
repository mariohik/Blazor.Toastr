using Blazor.Toastr.Enums;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace Blazor.Toastr
{
    internal static class Interop
    {
        public static ToastrOptionsInternal toastrOptions;

        internal static IJSRuntime JsRuntime { get; set; }

        public static void ShowToastr(ToastrType toastrType, string message, string title = null, ToastrOptions options = null)
        {
            switch (toastrType)
            {
                case ToastrType.Success:
                    JsRuntime.InvokeAsync<string>("toastrInterop.success", message, title, JsonConvert.SerializeObject(toastrOptions ?? options.ToInternal()));
                    break;
                case ToastrType.Info:
                    JsRuntime.InvokeAsync<string>("toastrInterop.info", message, title, JsonConvert.SerializeObject(toastrOptions ?? options.ToInternal()));
                    break;
                case ToastrType.Warning:
                    JsRuntime.InvokeAsync<string>("toastrInterop.warning", message, title, JsonConvert.SerializeObject(toastrOptions ?? options.ToInternal()));
                    break;
                case ToastrType.Error:
                    JsRuntime.InvokeAsync<string>("toastrInterop.error", message, title, JsonConvert.SerializeObject(toastrOptions ?? options.ToInternal()));
                    break;
                default:
                    break;
            }
        }
    }
}
