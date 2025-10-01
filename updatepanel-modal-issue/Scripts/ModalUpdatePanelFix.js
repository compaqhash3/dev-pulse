// Fix issue with UpdatePanel breaking modal events
Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
    $('#updLineModal').modal({
        backdrop: 'static',
        keyboard: false
    });
});
