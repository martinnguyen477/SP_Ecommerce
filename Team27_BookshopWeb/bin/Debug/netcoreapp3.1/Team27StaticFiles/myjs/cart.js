$(document).ready(function () {
    //Thêm sách vào giỏ hàng
    $(document).on('click', '.addToCart', function (e) {
        var proid = $(this).data('proid');
        var proqt;
        if ($(this).hasClass("normal")) {
            //Lấy số lượng
            proqt = parseInt($(this).data('proqt'));
        }
        else {
            //Lấy số lượng
            proqt = parseInt($(this).closest('.add-to-cart-row').find('#quantity').val());
        }
        HandleCart(proid, proqt);
    });

    //Tăng giảm số lượng trong giỏ hàng
    $(document).on('click', '.pro-qty button.cart.quantity.up , button.cart.quantity.down', function (e) {
        var proid = $(this).data('proid');
        var proqt = 1;
        var currentqt = $(this).closest("div.pro-qty").find("input.form-control.text-center");
        //Chọn giảm số lượng
        if ($(this).hasClass("down")) {
            //Số lượng hiện tại là 1 thì không được giảm
            if (currentqt.val() <= 1) {
                Swal.fire({
                    position: 'center',
                    icon: 'warning',
                    title: 'Số lượng tối thiểu 1',
                    showConfirmButton: true,
                });
                return;
            }
            else proqt = -1;
        }
        HandleCart(proid, proqt, currentqt);
    });

    //Xóa sách khỏi giỏ hàng
    $(document).on("click", ".cart-block button.remove-cart-item, .pro-remove button.cart_remove", function (e) {
        var currentRow = $(this).closest("div.cart-product");
        var bookId = $(this).data("bookid");
        var currentTableRow = $(this).closest("tr");
        
        if (bookId != "") {
            $.ajax({
                url: '/Cart/RemoveCartItem',
                type: 'post',
                data: {
                    bookId: bookId
                },
                success: function (response) {
                    var res = JSON.parse(JSON.stringify(response));
                    if (res.isSuccess || res.isSuccess == null) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Xóa sách trong giỏ hàng thành công',
                            showConfirmButton: false,
                            timer: 1000
                        });

                        //Xóa sách  trong cart-block list
                        $(".cart-block").html(res);

                        var total = $(".cart-widget .cart-block span.price span").text();
                        //Thay đổi cart summary
                        if ($(".cart-summary").find("#subtotal").length > 0) {
                            $(".cart-summary").find("span#subtotal").text(total);
                        }

                        //Nếu chọn xóa ở table thì xóa dòng của sách đó
                        if (currentTableRow.length > 0) {
                            currentTableRow.remove();
                        }
                        else {
                            //Chọn xóa ở cart-block thì xóa cả dòng đó tại table
                            $("div.cart-table .table tbody").find("tr#" + bookId).remove();
                        }

                        //Nếu giỏ hàng trống
                        if ($(".cart-table .table tbody").children().length <= 0) {
                            $("div.cart-table").html("<div>Giỏ hàng trống</div>");
                        }
                    }
                    else {
                        console.log(res.messages);
                        Swal.fire({
                            icon: "error",
                            title: 'Lỗi',
                            text: res.messages,
                            type: 'error',
                            confirmButtonText: 'Đóng'
                        });
                    }
                },
                error: function (err) {
                    console.log(err);
                    //Hiện thông báo lỗi
                    Swal.fire({
                        icon: "error",
                        title: 'Lỗi',
                        text: 'Xảy ra lỗi trong khi xóa sản phẩm trong giỏ hàng',
                        type: 'error',
                        confirmButtonText: 'Đóng'
                    });
                }
            });
        }
    });

    //Chọn sản phẩm trong giỏ hàng để thanh toán
    $(document).on("change", ".cart-checkbox", function (e) {
        var proid = $(this).closest("tr").attr("id");
        var select = 0;
        select = ($(this).is(":checked")) ? 1 : 0;
        $.ajax({
            url: '/Cart/SelectCheckoutItem',
            type: "post",
            data: {
                bookId: proid,
                select: select
            },
            dataType: 'json',
            success: function (response) {
                var res = JSON.parse(JSON.stringify(response));
                if (!res.isSuccess) {
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: 'Không thể chọn thanh toán sản phẩm này',
                        showConfirmButton: true
                    });
                }
            },
            error: function (err) {
                console.log(err);
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Xảy ra lỗi khi chọn thanh toán',
                    showConfirmButton: true
                });
            }

        });
    });
});

function HandleCart(proid, proqt, currentqt) {
    $.ajax({
        url: '/Cart/HandleCart',
        type: 'post',
        data: {
            bookId: proid,
            quantity: proqt
        },
        success: function (response) {
            var res = JSON.parse(JSON.stringify(response));
            if (res.isSuccess == null || res.isSuccess) {
                if (res.messages == "Add") {
                    $.ajax({
                        url: '/Cart/LoadCartBlock',
                        type: 'get',
                        dataType: 'html'
                    })
                    .done(function (response) {
                        //Cập nhật cart-block list
                        $(".cart-block").html(response);
                    })
                    .fail(function (jqXHR, textStatus, errorThrown) {
                        Swal.fire({
                            icon: "error",
                            title: 'Lỗi',
                            text: res.messages,
                            type: 'error',
                            confirmButtonText: 'Đóng'
                        });
                    });
                }
                else {
                    //Cập nhật cart-block list
                    $(".cart-block").html(res);
                }
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Cập nhật giỏ hàng thành công',
                    showConfirmButton: false,
                    timer: 1000
                });

                //Cập nhật số lượng ở trang cart
                if (currentqt != null) currentqt.val(parseInt(currentqt.val()) + parseInt(proqt));

                var cartBlock = $(".cart-widget .cart-block");
                var total = $(".cart-widget .cart-block span.price span").text();

                //Thay đổi cart summary
                if ($(".cart-summary").find("#subtotal").length > 0) {
                    $(".cart-summary").find("span#subtotal").text(total);
                }

                //Nếu thêm mới khi đang ở trang cart thì load trang
                if ($(location).attr("pathname").indexOf("cart") >= 0) location.reload();
            }
            else {
                Swal.fire({
                    icon: "error",
                    title: 'Lỗi',
                    text: res.messages,
                    type: 'error',
                    confirmButtonText: 'Đóng'
                });
            }
        },
        error: function (err) {
            console.log(err);
            //Hiện thông báo lỗi
            Swal.fire({
                icon: "error",
                title: 'Lỗi',
                text: 'Xảy ra lỗi trong khi cập nhật giỏ hàng',
                type: 'error',
                confirmButtonText: 'Đóng'
            });
        }

    });
}