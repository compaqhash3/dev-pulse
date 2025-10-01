// Cleanup after modal close
$('#myModal').on('hidden.bs.modal', function () {
    $(this).removeAttr('data-keep-open');
    $('.modal-backdrop').remove(); // cleanup duplicate backdrops
});
