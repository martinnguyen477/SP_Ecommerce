$(document).ready(function() {
	$('.btn.huydh').on('click', function(){
		var proid = $(this).data('proid');
		var button = $(this);
        var statusField = $(this).closest('tr').find('td.status');
        if (proid == "" || proid === null) {
            //Hiện thông báo lỗi
            Swal.fire({
                icon: "error",
                title: 'Lỗi',
                text: 'Lỗi không thể hủy đơn hàng!',
                type: 'error',
                confirmButtonText: 'Đóng'
            })
            return;
        }
        $.ajax({
            url: '/User/UpdateStatus',
            data: {
                id: proid
            },
			dataType: 'json',
            success: function (response) {
                var res = JSON.parse(JSON.stringify(response));
				if (res.isSuccess){
					// Hủy thành công
					// Sửa trạng thái tại danh sách thành hủy
                    statusField.text('Hủy');
					//Ẩn button Hủy
                    button.css('display', 'none');
                    ShowAlertWithClose("success", "Đã hủy đơn hàng thành công");
				}
				else {
                    //Hiện thông báo lỗi
                    $.each(res.messages, function (index, value) {
                        ShowAlertWithClose("error", value)
                    });
				}
			},
            error: function (req, err) {
                console.log(err);
                //Hiện thông báo lỗi
                Swal.fire({
                    icon: "error",
                    title: 'Lỗi',
                    text: 'Lỗi không thể hủy đơn hàng!',
                    type: 'error',
                    confirmButtonText: 'Đóng'
                })
            }
		});
	});
});