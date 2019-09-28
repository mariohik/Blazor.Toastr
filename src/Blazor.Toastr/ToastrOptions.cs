using Blazor.Toastr.Enums;

namespace Blazor.Toastr
{
    public class ToastrOptions
    {
        public bool closeButton { get; set; } = false;

        public bool debug { get; set; } = false;

        public bool newestOnTop { get; set; } = false;

        public bool progressBar { get; set; } = false;

        public PositionClassType positionClass { get; set; } = PositionClassType.TopRight;

        public bool preventDuplicates { get; set; } = false;

        public string onClick { get; set; } = null;

        public long showDuration { get; set; } = 300;

        public long hideDuration { get; set; } = 1000;

        public long timeOut { get; set; } = 5000;

        public long extendedTimeOut { get; set; } = 1000;

        public EasingType showEasing { get; set; } = EasingType.Swing;

        public EasingType hideEasing { get; set; } = EasingType.Linear;

        public EffectType showMethod { get; set; } = EffectType.FadeIn;

        public EffectType hideMethod { get; set; } = EffectType.FadeOut;

        internal ToastrOptionsInternal ToInternal()
        {
            var intOptions = new ToastrOptionsInternal();
            switch (positionClass)
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
            intOptions.closeButton = closeButton;
            intOptions.debug = debug;
            intOptions.newestOnTop = newestOnTop;
            intOptions.progressBar = progressBar;
            intOptions.preventDuplicates = preventDuplicates;
            intOptions.onclick = onClick;
            intOptions.showDuration = showDuration;
            intOptions.hideDuration = hideDuration;
            intOptions.timeOut = timeOut;
            intOptions.extendedTimeOut = extendedTimeOut;
            switch (showEasing)
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
            switch (hideEasing)
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
            switch (showMethod)
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
            switch (hideMethod)
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
            return intOptions;
        }
    }
}
