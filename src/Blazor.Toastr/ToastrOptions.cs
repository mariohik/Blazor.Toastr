namespace Blazor.Toastr
{
    public class ToastrOptions
    {
        public bool closeButton { get; set; } = false;

        public bool debug { get; set; } = false;

        public bool newestOnTop { get; set; } = false;

        public bool progressBar { get; set; } = false;

        public string positionClass { get; set; } = "toast-top-right";

        public bool preventDuplicates { get; set; } = false;

        public string onclick { get; set; } = null;

        public long showDuration { get; set; } = 300;

        public long hideDuration { get; set; } = 1000;

        public long timeOut { get; set; } = 5000;

        public long extendedTimeOut { get; set; } = 1000;

        public string showEasing { get; set; } = "swing";

        public string hideEasing { get; set; } = "linear";

        public string showMethod { get; set; } = "fadeIn";

        public string hideMethod { get; set; } = "fadeOut";

    }
}
