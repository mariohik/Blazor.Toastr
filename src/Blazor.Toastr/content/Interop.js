Blazor.registerFunction("Blazor.Toastr.Success",
    (message, title) => {
        toastr.success(message, title);
    });

Blazor.registerFunction("Blazor.Toastr.Info",
    (message, title) => {
        toastr.info(message, title);
    });

Blazor.registerFunction("Blazor.Toastr.Warning",
    (message, title) => {
        toastr.warning(message, title);
    });

Blazor.registerFunction("Blazor.Toastr.Error",
    (message, title) => {
        toastr.error(message, title);
    });

Blazor.registerFunction("Blazor.Toastr.ConfigOptions",
    (options) => {
        toastr.options = $.parseJSON(options);
    });
