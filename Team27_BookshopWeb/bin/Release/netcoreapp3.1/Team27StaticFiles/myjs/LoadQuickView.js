$(document).ready(function () {
    //Open modal quick view
    $("body").on('click', '.quick-view-btn', function (event) {
        event.preventDefault();
        var bookId = $(this).data("proid");

        //Gọi ajax render parital view
        $.ajax({
            url: '/ProductDetails/QuickView',
            type: 'POST',
            dataType: 'html',
            data: { id: bookId },
        })
        .done(function (reponse) {
            console.log("success");
            $("#qv-modal-area").html(reponse);
            //Show modal
            $("#quickModal").modal("show");
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus);
            Swal.fire({
                icon: "error",
                title: 'Lỗi',
                text: 'Lỗi không thể xem sách hoặc sách không tồn tại!',
                type: 'error',
                confirmButtonText: 'Đóng'
            })
        });
    });

    //Close modal
    $(document).on('click', '.modal-backdrop, .modal .close.modal-close-btn', function (event) {
        $("#quickModal").modal("hide");
    });
});