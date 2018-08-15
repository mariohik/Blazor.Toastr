window.toastrInterop = {
    success: function (message, title, options) {
        return toastr.success(message, title, $.parseJSON(options));
    },
    error: function (message, title, options) {
        return toastr.error(message, title, $.parseJSON(options));
    },
    info: function (message, title, options) {
        return toastr.info(message, title, $.parseJSON(options));
    },
    warning: function (message, title, options) {
        return toastr.warning(message, title, $.parseJSON(options));
    }
};
