$(document).ready(function () {
    //Áp dụng mã khuyến mãi
    $(document).on("click", ".btn-apply-coupon", function (e) {
        e.preventDefault();
        $(this).text("XÓA MÃ");
        $(this).removeClass("btn-apply-coupon");
        $(this).addClass("btn-remove-coupon");
        var coupon = $("#coupon-form").find("input[name='coupon']").val();
        var subtotal = parseFloat($("span#subtotal").data("subtotal"));
        $.ajax({
            url: '/Checkout/ApplyCoupon',
            type: 'GET',
            dataType: 'json',
            data: {
                code: coupon
            }
        })
        .done(function (response) {
            var res = JSON.parse(JSON.stringify(response));
            console.log("success");
            if (res.isSuccess) {
                if (subtotal >= res.data.minPrice) {
                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Áp dụng mã khuyến mãi thành công',
                        showConfirmButton: 'Đóng',
                    });
                    //Tính giá tiền sau khi áp dụng mã khuyến mãi
                    var newTotal;
                    if (res.data.isFixed == 1) {
                        newTotal = subtotal - res.data.discountAmount;
                    }
                    else {
                        newTotal = subtotal * (100 - res.data.discountAmount) / 100;
                    }
                    //Hiển thị giá tiền
                    $("#total").text(newTotal.toLocaleString('vi') + ' VND');
                    //Hiển thị code
                    $("#coupon-code").text(res.data.code);
                    //Store code
                    $("input#Coupon").val(res.data.code);
                }
                else {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Đơn hàng phải tối thiểu ' + res.data.minPrice.toLocaleString('vi') + ' VND',
                        showConfirmButton: 'Đóng',
                    });
                }
            }
            else {
                $.each(res.messages, function (index, value) {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: value,
                        showConfirmButton: 'Đóng'
                    });
                });
            }
        })
        .fail(function (error) {
            console.log(error);
            Swal.fire({
                icon: "error",
                title: 'Lỗi',
                text: 'Lỗi không thể áp dụng mã khuyến mãi',
                type: 'error',
                confirmButtonText: 'Đóng'
            })
        });
    });

    //Hủy mã khuyến mãi
    $(document).on("click", ".btn-remove-coupon", function (e) {
        e.preventDefault();
        $(this).text("ÁP DỤNG");
        $(this).removeClass("btn-remove-coupon");
        $(this).addClass("btn-apply-coupon");
        var coupon = $("#coupon-form").find("input[name='coupon']").val("");
        var subtotal = parseFloat($("span#subtotal").data("subtotal"));
        //Hiển thị giá tiền
        $("#total").text(subtotal.toLocaleString('vi') + ' VND');
        //Hiển thị code
        $("#coupon-code").text("");
        //Store code
        $("input#Coupon").val("");
    });
});