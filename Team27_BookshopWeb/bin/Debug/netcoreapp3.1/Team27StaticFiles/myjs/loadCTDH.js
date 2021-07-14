$(document).ready(function () {
    $(document).on('click', '.ctdh', function () {
        jQuery.noConflict();
        var orderId = $(this).data('proid');
        //Kiểm tra đang ở trang admin hay trang tài khoản khách hàng
        var data = {
            Id: orderId
        }
        $.ajax({
            url: "/admin/Order/Details",
            dataType: 'html',
            data: data,
            success: function (response) {
                $("#modalCTDH").html(response);
                $("#modalOrderDetail").modal("show");
            },
            error: function (err) {
                console.log(err);
                //Hiện thông báo lỗi
                Swal.fire({
                    icon: "error",
                    title: 'Lỗi',
                    text: 'Lỗi không thể load đơn hàng!',
                    type: 'error',
                    confirmButtonText: 'Đóng'
                })
            }
        });
    });

    //Button quay về (sau khi xem lịch sử đơn hàng) ở trang tài khoản của tôi
    $('#btn-back').on('click', function () {
        jQuery.noConflict();
        $('.myaccount-table.table-responsive.text-center').css('display', 'block');
        $('#bill-detail').css('display', 'none');
    });
});