$(document).ready(function () {
    window.onload = LoadSearchFilter();
    //Validate form thêm sách
    $("#bookform").validate({
        rules: {
            PrimaryImage: { required: true },
            Pages: {
                min: 1
            },
            PublicationYear: {  min: 1 }
        },
        messages: {
            PrimaryImage: { required: "Ảnh đại diện của sách không được trống" },
            Price: {
                required: "Giá bán không được trống",
                min: "Giá bán phải lớn hơn hoặc bằng 0"
            },
            Pages: {
                min: "Số trang phải lớn hơn hoặc bằng 1"
            },
            PublicationYear: { min: "Năm xuất bản phải lớn hơn hoặc bằng 1" }
        }
    });

    //Tạm xóa
    $(document).on("click", "button.xoa, button.btnRestore, button.btnDeleteForever", function () {
        var tr = $(this).closest("tr");
        var bookId = tr.find("span.block-email.bookId").text();
        //Lấy tên action
        var action = $(this).data("action");
        //Lấy title để hiển thị message
        var actionTitle = $(this).attr("data-original-title");  

        //Confirm
        Swal.fire({
            title: actionTitle,
            text: "Bạn chắc chắn muốn " + actionTitle.toLowerCase() + " sách này? ",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Không',
            confirmButtonText: 'Có'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '/admin/Book/' + action,
                    type: 'GET',
                    dataType: 'json',
                    data: { id: bookId },
                })
                .done(function (response) {
                    var res = JSON.parse(JSON.stringify(response));
                    if (res.isSuccess) {
                        //Thành công
                        //Xóa dòng dữ liệu
                        tr.remove();
                        //Hiện alert
                        $.each(res.messages, function (index, value) {
                            ShowAlertWithClose("success", value)
                        });
                    }
                    else {
                        //Hiện alert
                        $.each(res.messages, function (index, value) {
                            ShowAlertWithClose("error", value)
                        });
                    }
                })
                .fail(function (error) {
                    //Hiện thông báo lỗi
                    Swal.fire({
                        icon: "error",
                        title: 'Lỗi',
                        text: 'Xảy ra lỗi. Vui lòng load lại trang',
                        type: 'error',
                        confirmButtonText: 'Đóng'
                    });
                });
            }
        });
    });


    // Reset hộp thoại tìm kiếm
    $('#btnSearchClose').on('click', function () {
        //Reset giá trị
        $("#text-input").val("");
        $("#text-input").attr("disabled", "disabled");
        $("#search-form").submit();
    });

    //Kiểm tra dữ liệu trước khi search
    $(document).on("click", "#btnSearch", function (e) {
        e.preventDefault();
        var search = $("#text-input").val();
        console.log(search);
        if (search == null || search == "") {
            ShowAlertWithClose("error", "Tìm kiếm không được trống");
            return;
        }
        $("#search-form").submit();
    });

    // Các option filter
    $('#filtertype').on('change', function () {
        //Lấy giá trị filter
        var filterType = $(this).val();
        var filter = $(this).data("filter");

        if (filterType != "Default" && filterType != "Deleted") {
            ShowFilterBox(filterType, filter);
        }
        else {
            //Xóa filter
            $(".filter-area #filter-option *").remove();
            $("#search-form").submit();
        }
    });
});

//Hiển thị search và filter sau khi load
function LoadSearchFilter() {
    //Lấy dữ liệu filter để hiển thị
    var filtertype = getParameterByName("filtertype");
    var filter = getParameterByName("filter");
    if (filtertype != "Default" && filtertype != "Deleted" && filtertype != null) {
        ShowFilterBox(filtertype, filter);
    }
}

//Gọi ajax hiển thị các option của filter
function ShowFilterBox(filtertype, filter) {
    $.ajax({
        url: '/admin/Book/GetFilter',
        dataType: 'html',
        data: {
            filterType: filtertype,
            filter: filter
        },
    })
        .done(function (response) {
            //Hiển thị các option của filter đã chọn
            $(".filter-area #filter-option").html(response);
        })
        .fail(function (error) {
            console.log(error);
            //Hiện thông báo lỗi
            Swal.fire({
                icon: "error",
                title: 'Lỗi',
                text: 'Lỗi không thể load filter!',
                type: 'error',
                confirmButtonText: 'Đóng'
            })
        });
}