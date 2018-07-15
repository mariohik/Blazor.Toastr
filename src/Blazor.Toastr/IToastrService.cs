using Blazor.Toastr.Enums;

namespace Blazor.Toastr
{
    public interface IToastrService
    {
        void Show(ToastrType toastrType, string message, string title = null);
    }
}
