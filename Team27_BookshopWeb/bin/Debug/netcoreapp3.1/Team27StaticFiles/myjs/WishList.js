$(document).ready(function () {
    $(document).on('click', '.addToWishList, .yeuthich_remove', function () {
        var bookId = $(this).data("proid");
        console.log(bookId);
        var currentButton = $(this);
        //icon heart tại vị trí đang click
        var currentIcon = $(this).find('.fas.fa-heart');
        //icon heart lúc hover
        var hoverIcon = $('.single-btn.addToWishList[data-proid=' + bookId + ']').find('.fas.fa-heart');
        var description = "";

        // Khách hàng đã đăng nhập
        $.ajax({
            url: "/User/HandleWishlist",
            data: {
                bookId: bookId
            },
            dataType: "json",
            success: function (response) {
                var res = JSON.parse(JSON.stringify(response));
                if (res.isSuccess) {
                    //Thêm/Xóa thành công
                    if (res.data == "add") {
                        //Thêm
                        // Chuyển màu tại sách hiện tại
                        currentIcon.css('color', 'red');

                        // Chuyển màu tại hover
                        hoverIcon.css('color', 'red');

                        description = "thêm";
                    }
                    else {
                        //Xóa
                        // Chuyển màu tại sách hiện tại
                        currentIcon.css('color', 'black');

                        // Chuyển màu tại hover
                        hoverIcon.css('color', 'black');

                        description = "xóa";
                    }

                    if (currentButton.hasClass("yeuthich_remove")) {
                        currentButton.closest("tr").remove();
                    }

                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Sách đã được ' + description + ' trong danh sách yêu thích',
                        showConfirmButton: false,
                        timer: 1000
                    })
                }
                else {
                    //Thất bại
                    Swal.fire({
                        icon: "error",
                        title: 'Lỗi',
                        text: 'Xảy ra lỗi',
                        type: 'error',
                        confirmButtonText: 'Đóng'
                    })
                }
            },
            error: function (err) {
                console.log(err);
                //Lỗi authorize
                if (err.status == 401) {
                    Swal.fire({
                        icon: "warning",
                        text: 'Đăng nhập để sử dụng chức năng này',
                        type: 'warning',
                        confirmButtonText: 'Đóng'
                    });
                    return;
                }

                Swal.fire({
                    icon: "error",
                    title: 'Lỗi',
                    text: 'Xảy ra lỗi',
                    type: 'error',
                    confirmButtonText: 'Đóng'
                })
            }
        });


    });
});