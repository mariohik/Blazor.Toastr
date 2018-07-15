using Blazor.Toastr.Enums;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Blazor.Toastr
{
    internal static class Interop
    {
        public static void ShowToastr(ToastrType toastrType, string message, string title = null)
        {
            switch (toastrType)
            {
                case ToastrType.Success:
                    RegisteredFunction.Invoke<bool>("Blazor.Toastr.Success", message, title);
                    break;
                case ToastrType.Info:
                    RegisteredFunction.Invoke<bool>("Blazor.Toastr.Info", message, title);
                    break;
                case ToastrType.Warning:
                    RegisteredFunction.Invoke<bool>("Blazor.Toastr.Warning", message, title);
                    break;
                case ToastrType.Error:
                    RegisteredFunction.Invoke<bool>("Blazor.Toastr.Error", message, title);
                    break;
                default:
                    break;
            }
        }

        public static void ConfigOptions(ToastrOptions toastrOptions)
        {
            RegisteredFunction.Invoke<bool>("Blazor.Toastr.ConfigOptions", JsonUtil.Serialize(toastrOptions));
        }
    }
}
