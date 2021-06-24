$(document).ready(function () {
    window.onload = LoadSearchFilter();
	// Reset hộp thoại tìm kiếm
    $('#btnSearchClose').on('click', function () {
        //Reset giá trị
        $("#selectType").val("0");
        ShowSearchBox(0);
        $('.searchbox #from-date-input').attr('disabled', 'disabled');
        $('.searchbox #to-date-input').attr('disabled', 'disabled');
        $("#search-form").submit();
	});

	// Các option filter
    $('#filtertype').on('change', function () {
        //Lấy giá trị filter
        var filterType = $(this).val();
        var filter = $(this).data("filter");

        if (filterType != "Default") {
            ShowFilterBox(filterType, filter);
        }
        else {
            //Xóa filter
            $(".filter-area #filter-option *").remove();
            $("#search-form").submit();
        }
	});

	// Cập nhật tình trạng đơn hàng
	$(document).on('change', '.orderstatus.admin', function(){
        var orderId = $(this).data('orderid');
        var statusControl = $(this);
        var cur_row = $(this).closest('tr');
        var data = {
            id: orderId,
            status: statusControl.val()
        }
		$.ajax({
            url: "/admin/Order/UpdateStatus",
            data: data,
			dataType: 'json',
			success: function(response){
				var res = JSON.parse(JSON.stringify(response));
                if (!res.isSuccess) {
                    //Thất bại
                    //Hiển thị trạng thái đơn hàng cũ
					if (res.data != "") {
                        statusControl.val(res.data);
					}
					// Hiện alert
                    ShowAlertWithClose("error", res.messages);
                }
                else {
                    // Thành công
                    // Hiện alert
                    // Thay đổi tình trạng thanh toán
                    switch (statusControl.val()) {
                        // Nếu Giao hàng thành công -> Đã thanh toán
                        case "4":
                            cur_row.find('.payment_status').html("Đã thanh toán");
                            break;

                        // Nếu Hủy đơn hàng -> Chưa thanh toán
                        case "5":
                            cur_row.find('.payment_status').html("Chưa thanh toán");
                            break;

                        default:
                            cur_row.find('.payment_status').html("Chưa thanh toán");
                            break;
                    }
                    // Hiện alert
                    ShowAlertWithClose("success", "Cập nhật đơn hàng thành công");
                }

			},
            error: function (req, err) {
                console.log(err);
                //Hiện thông báo lỗi
                Swal.fire({
                    icon: "error",
                    title: 'Lỗi',
                    text: 'Không thể cập nhật trạng thái đơn hàng',
                    type: 'error',
                    confirmButtonText: 'Đóng'
                })
            }
		});
	});

	// Mở các option để tìm kiếm
	$('.searchbox #selectType').on('change', function(){
        var opt = parseInt($(this).val());
        ShowSearchBox(opt);
    });

    //Kiểm tra dữ liệu trước khi search
    $(document).on("click", "#btnSearch", function (e) {
        e.preventDefault();
        var searchType = parseInt($('.searchbox #selectType').val());
        console.log(typeof(searchType));
        switch (searchType) {
            case 1: case 2:
                var search = $('.searchbox #text-input').val()
                if (search == "") {
                    // Hiện alert
                    ShowAlertWithClose("error", "Tìm kiếm không được trống");
                    return;
                }
                break;
            case 3:
                var fromDate = $('input[name="fromdate"]').val();
                var toDate = $('input[name="todate"]').val();
                console.log(fromDate);
                if (fromDate == "" || toDate == "") {
                    // Hiện alert
                    ShowAlertWithClose("error", "Ngày bắt đầu và ngày kết thúc không được trống");
                    return;
                }
                if ((Date.parse(fromDate) > Date.parse(toDate))) {
                    // fromDate > toDate
                    // Hiện alert
                    ShowAlertWithClose("error", "Ngày bắt đầu không được lớn hơn ngày kết thúc");
                    return;
                }
                break;
            default:
                break;
        }
        $("#search-form").submit();
    });
});
//Hiển thị search và filter sau khi load
function LoadSearchFilter() {
    ShowSearchBox($('.searchbox #selectType').val());
    //Lấy dữ liệu filter để hiển thị
    var filtertype = getParameterByName("filtertype");
    var filter = getParameterByName("filter");
    if (filtertype != "Default" && filtertype != null) {
        ShowFilterBox(filtertype, filter);
    }
}

//Gọi ajax hiển thị các option của filter
function ShowFilterBox(filtertype, filter) {
    $.ajax({
        url: '/admin/Order/GetFilter',
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

//Hiển thị các option search
function ShowSearchBox(opt) {
    var opts = parseInt(opt);
    switch (opts) {
        case 1: case 2:
            $('.searchbox #text-input').css('display', 'block');
            $('.searchbox #text-input').removeAttr("disabled");
            $('.searchbox #from-date-input').css('display', 'none');
            $('.searchbox #to-date-input').css('display', 'none');
            $('.searchbox #from-date-input').attr('disabled', 'disabled');
            $('.searchbox #to-date-input').attr('disabled', 'disabled');
            $('.searchbox span#arrow').css('display', 'none');
            break;
        case 3:
            $('.searchbox #text-input').css('display', 'none');
            $('.searchbox #text-input').attr('disabled', 'disabled');
            $('.searchbox #from-date-input').css('display', 'block');
            $('.searchbox #to-date-input').css('display', 'block');
            $('.searchbox #from-date-input').removeAttr("disabled");
            $('.searchbox #to-date-input').removeAttr("disabled");
            $('.searchbox span#arrow').css('display', 'block');
            break;
        default:
            $('.searchbox #text-input').css('display', 'none');
            $('.searchbox #text-input').attr('disabled', 'disabled');
            $('.searchbox #from-date-input').css('display', 'none');
            $('.searchbox #to-date-input').css('display', 'none');
            $('.searchbox #from-date-input').attr('disabled', 'disabled');
            $('.searchbox #to-date-input').attr('disabled', 'disabled');
            $('.searchbox span#arrow').css('display', 'none');
            break;
    }
}
