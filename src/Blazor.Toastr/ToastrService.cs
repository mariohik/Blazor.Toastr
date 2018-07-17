using Blazor.Toastr.Enums;

namespace Blazor.Toastr
{
    public class ToastrService : IToastrService
    {
        public ToastrService()
        {
            ConfigOptions(new ToastrOptions());
        }

        public ToastrService(ToastrOptions extOptions)
        {
            ConfigOptions(extOptions);
        }

        private static void ConfigOptions(ToastrOptions extOptions)
        {
            var intOptions = new ToastrOptionsInternal();
            switch (extOptions.positionClass)
            {
                case PositionClassType.TopRight:
                    intOptions.positionClass = "toast-top-right";
                    break;
                case PositionClassType.TopLeft:
                    intOptions.positionClass = "toast-top-left";
                    break;
                case PositionClassType.TopCenter:
                    intOptions.positionClass = "toast-top-center";
                    break;
                case PositionClassType.TopFullWidth:
                    intOptions.positionClass = "toast-top-full-width";
                    break;
                case PositionClassType.BottomRight:
                    intOptions.positionClass = "toast-bottom-right";
                    break;
                case PositionClassType.BottomLeft:
                    intOptions.positionClass = "toast-bottom-left";
                    break;
                case PositionClassType.BottomCenter:
                    intOptions.positionClass = "toast-bottom-center";
                    break;
                case PositionClassType.BottomFullWidth:
                    intOptions.positionClass = "toast-bottom-full-width";
                    break;
                default:
                    intOptions.positionClass = "toast-top-right";
                    break;
            }
            intOptions.closeButton = extOptions.closeButton;
            intOptions.debug = extOptions.debug;
            intOptions.newestOnTop = extOptions.newestOnTop;
            intOptions.progressBar = extOptions.progressBar;
            intOptions.preventDuplicates = extOptions.preventDuplicates;
            intOptions.onclick = extOptions.onClick;
            intOptions.showDuration = extOptions.showDuration;
            intOptions.hideDuration = extOptions.hideDuration;
            intOptions.timeOut = extOptions.timeOut;
            intOptions.extendedTimeOut = extOptions.extendedTimeOut;
            switch (extOptions.showEasing)
            {
                case EasingType.Linear:
                    intOptions.showEasing = "linear";
                    break;
                case EasingType.Swing:
                    intOptions.showEasing = "swing";
                    break;
                case EasingType.Default:
                    intOptions.showEasing = "default";
                    break;
                default:
                    intOptions.showEasing = "swing";
                    break;
            }
            switch (extOptions.hideEasing)
            {
                case EasingType.Linear:
                    intOptions.hideEasing = "linear";
                    break;
                case EasingType.Swing:
                    intOptions.hideEasing = "swing";
                    break;
                case EasingType.Default:
                    intOptions.hideEasing = "default";
                    break;
                default:
                    intOptions.hideEasing = "linear";
                    break;
            }
            switch (extOptions.showMethod)
            {
                case EffectType.FadeIn:
                    intOptions.showMethod = "fadeIn";
                    break;
                case EffectType.FadeOut:
                    intOptions.showMethod = "fadeOut";
                    break;
                case EffectType.SlideIn:
                    intOptions.showMethod = "slideIn";
                    break;
                case EffectType.SlideOut:
                    intOptions.showMethod = "slideOut";
                    break;
                default:
                    intOptions.showMethod = "fadeIn";
                    break;
            }
            switch (extOptions.hideMethod)
            {
                case EffectType.FadeIn:
                    intOptions.hideMethod = "fadeIn";
                    break;
                case EffectType.FadeOut:
                    intOptions.hideMethod = "fadeOut";
                    break;
                case EffectType.SlideIn:
                    intOptions.hideMethod = "slideIn";
                    break;
                case EffectType.SlideOut:
                    intOptions.hideMethod = "slideOut";
                    break;
                default:
                    intOptions.hideMethod = "fadeOut";
                    break;
            }

            Interop.ConfigOptions(intOptions);
        }

        //public ToastrService(bool closeButton = false, bool debug = false, bool newestOnTop = false, bool progressBar = false,
        //    PositionClassType positionClass = PositionClassType.TopRight, bool preventDuplicates = false, string onClick = null, long showDuration = 300, long hideDuration = 1000,
        //    long timeOut = 5000, long extendedTimeOut = 1000, EasingType showEasing = EasingType.Swing, EasingType hideEasing = EasingType.Linear,
        //    EffectType showMethod = EffectType.FadeIn, EffectType hideMethod = EffectType.FadeOut)
        //{
        //    var options = new ToastrOptionsInternal();
        //    switch (positionClass)
        //    {
        //        case PositionClassType.TopRight:
        //            options.positionClass = "toast-top-right";
        //            break;
        //        case PositionClassType.TopLeft:
        //            options.positionClass = "toast-top-left";
        //            break;
        //        case PositionClassType.TopCenter:
        //            options.positionClass = "toast-top-center";
        //            break;
        //        case PositionClassType.TopFullWidth:
        //            options.positionClass = "toast-top-full-width";
        //            break;
        //        case PositionClassType.BottomRight:
        //            options.positionClass = "toast-bottom-right";
        //            break;
        //        case PositionClassType.BottomLeft:
        //            options.positionClass = "toast-bottom-left";
        //            break;
        //        case PositionClassType.BottomCenter:
        //            options.positionClass = "toast-bottom-center";
        //            break;
        //        case PositionClassType.BottomFullWidth:
        //            options.positionClass = "toast-bottom-full-width";
        //            break;
        //        default:
        //            options.positionClass = "toast-top-right";
        //            break;
        //    }
        //    options.closeButton = closeButton;
        //    options.debug = debug;
        //    options.newestOnTop = newestOnTop;
        //    options.progressBar = progressBar;
        //    options.preventDuplicates = preventDuplicates;
        //    options.onclick = onClick;
        //    options.showDuration = showDuration;
        //    options.hideDuration = hideDuration;
        //    options.timeOut = timeOut;
        //    options.extendedTimeOut = extendedTimeOut;
        //    switch (showEasing)
        //    {
        //        case EasingType.Linear:
        //            options.showEasing = "linear";
        //            break;
        //        case EasingType.Swing:
        //            options.showEasing = "swing";
        //            break;
        //        case EasingType.Default:
        //            options.showEasing = "default";
        //            break;
        //        default:
        //            options.showEasing = "swing";
        //            break;
        //    }
        //    switch (hideEasing)
        //    {
        //        case EasingType.Linear:
        //            options.hideEasing = "linear";
        //            break;
        //        case EasingType.Swing:
        //            options.hideEasing = "swing";
        //            break;
        //        case EasingType.Default:
        //            options.hideEasing = "default";
        //            break;
        //        default:
        //            options.hideEasing = "linear";
        //            break;
        //    }
        //    switch (showMethod)
        //    {
        //        case EffectType.FadeIn:
        //            options.showMethod = "fadeIn";
        //            break;
        //        case EffectType.FadeOut:
        //            options.showMethod = "fadeOut";
        //            break;
        //        case EffectType.SlideIn:
        //            options.showMethod = "slideIn";
        //            break;
        //        case EffectType.SlideOut:
        //            options.showMethod = "slideOut";
        //            break;
        //        default:
        //            options.showMethod = "fadeIn";
        //            break;
        //    }
        //    switch (hideMethod)
        //    {
        //        case EffectType.FadeIn:
        //            options.hideMethod = "fadeIn";
        //            break;
        //        case EffectType.FadeOut:
        //            options.hideMethod = "fadeOut";
        //            break;
        //        case EffectType.SlideIn:
        //            options.hideMethod = "slideIn";
        //            break;
        //        case EffectType.SlideOut:
        //            options.hideMethod = "slideOut";
        //            break;
        //        default:
        //            options.hideMethod = "fadeOut";
        //            break;
        //    }

        //    Interop.ConfigOptions(options);
        //}

        public void Show(ToastrType toastrType, string message, string title = null)
        {
            Interop.ShowToastr(toastrType, message, title);
        }
    }
}
