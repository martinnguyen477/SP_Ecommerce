$(document).ready(function () {
	$(document).on('click', 'button.xoa', function (event) {
		event.preventDefault();
		var dongHienTai = $(this).closest('tr'); /* tìm thằng cha chứa nó gần nhất tức nó đang ở button -> tr chứa nó */
		var idCanXoa = $(this).data("id");
		console.log(idCanXoa);
		//Confirm
		Swal.fire({
			title: "Xóa",
			text: "Bạn chắc chắn muốn xóa nhân viên này? ",
			icon: 'warning',
			showCancelButton: true,
			confirmButtonColor: '#3085d6',
			cancelButtonColor: '#d33',
			cancelButtonText: 'Không',
			confirmButtonText: 'Có'
		}).then((result) => {
			if (result.isConfirmed) {
				$.ajax({
					url: '/admin/Employee/DeleteAjax',
					type: 'GET',
					dataType: 'json',
					data: { id: idCanXoa },
				})
					.done(function (respone) {
						/*chuỗi json chuyển sang dạng object*/
						var res = JSON.parse(JSON.stringify(respone)) /*respone trả về json từ controller -> chuỗi json -> object*/
						if (res.isSuccess) {
							dongHienTai.remove();
							$.each(res.messages, function (index, value) {
								ShowAlertWithClose("success", value);
							});

						}
						else {
							$.each(res.messages, function (index, value) {
								ShowAlertWithClose("error", value);
							});
						}
						console.log("success");
					})
					.fail(function (error) {
						console.log(error);
					});
			}
		});
	});
});