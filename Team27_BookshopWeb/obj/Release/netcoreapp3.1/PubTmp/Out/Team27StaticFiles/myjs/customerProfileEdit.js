$(document).ready(function () {
    //Customer Profile Update
    //Validate
    $("#edit-account-form").validate({
        rules: {
            Name: {
                required: true
            },
            Username: {
                required: true,
                remote: {
                    type: 'post',
                    url: '/User/UsernameVerify',
                    data: {
                        'username': function () { return $('#Username').val(); },
                        'id': function () { return $('#Id').val() }
                    },
                    dataType: 'json'
                },
            },
            Gender: {
                required: true
            },
            Phone: {
                required: true,
                valid_phone: true
            },
            Email: {
                valid_email: true,
                remote: {
                    type: 'post',
                    url: '/User/EmailVerify',
                    data: {
                        'email': function () { return $('#Email').val(); },
                        'id': function () { return $('#Id').val() }
                    },
                    dataType: 'json'
                },
            },
            Address: {
                required: true
            }
        },
        messages: {
            Name: {
                required: "Tên không được trống"
            },
            Username: {
                required: "Tên đăng nhập không được trống",
            },
            Phone: {
                required: "Số điện thoại không được trống",
                valid_phone: "Số điện thoại không hợp lệ",
            },
            Gender: {
                required: "Yêu cầu chọn giới tính"
            },
            Email: {
                valid_email: "Email không hợp lệ",
            },
            Address: {
                required: "Địa chỉ không được trống"
            }
        }
    });

    //Validate
    $("#edit-password-form").validate({
        rules: {
            CurrentPassword: {
                required: true,
                remote: {
                    type: 'post',
                    url: '/User/PasswordCheck',
                    data: {
                        'id': function () { return $('#Id').val() },
                        'pass': function () { return $('#CurrentPassword').val(); }
                    },
                    dataType: 'json'
                }
            },
            NewPassword: {
                required: true
            },
            PasswordConfirmation: {
                required: function () {
                    return $("#NewPassword").val() != "";
                },
                equalTo: "#NewPassword"
            }
        },
        messages: {
            CurrentPassword: {
                required: "Yêu cầu điền mật khẩu hiện tại",
                remote: "Mật khẩu hiện tại không đúng"
            },
            NewPassword: {
                required: "Yêu cầu điền mật khẩu mới"
            },
            PasswordConfirmation: {
                required: "Yêu cầu xác nhận mật khẩu",
                equalTo: "Xác nhận mật khẩu sai"
            }
        }
    });

	// Edit customer's account info AJAX
	$(document).on("click", "#edit-account-form .btnSave", function(e){
        e.preventDefault();
        if ($("#edit-account-form").valid()) {
            //Nếu dữ liệu đã valid
            // Lấy giá trị của form
            $("#edit-account-form").submit();
        }
    });

	// Edit customer's password info AJAX
    $(document).on("click", "#edit-password-form .btnEditPw", function (e) {
        e.preventDefault();
        if ($("#edit-password-form").valid()) {
            //Nếu dữ liệu đã valid
            // Lấy giá trị của form
            var form = $("#edit-password-form");
            var id = form.find("input#Id").val();
            var newPass = form.find("input#NewPassword").val();
            var curPass = form.find("input#CurrentPassword").val();
            if (newPass == curPass) {
                ShowAlertWithClose("error", "Bạn đang nhập mật khẩu cũ");
                return;
            }
            var data = {
                id: id,
                newPassword: newPass
            }
            $.ajax({
                url: '/User/EditPassword',
                type: 'post',
                dataType: 'json',
                data: data,
                success: function (response) {
                    var res = JSON.parse(JSON.stringify(response));
                    if (res.isSuccess) {	//Cập nhật thành công
                        // Cập nhật thông tin
                        $('#edit-password-form input#CurrentPassword').val("");
                        $('#edit-password-form input#NewPassword').val("");
                        $('#edit-password-form input#PasswordConfirmation').val("");
                        ShowAlertWithClose("success", res.messages);
                    }
                    else {
                        ShowAlertWithClose("error", res.messages);
                    }
                },
                error: function (error) {
                    console.log(error);
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
                    //Hiện thông báo lỗi
                    Swal.fire({
                        icon: "error",
                        title: 'Lỗi',
                        text: 'Xảy ra lỗi. Vui lòng load lại trang',
                        type: 'error',
                        confirmButtonText: 'Đóng'
                    });
                }
            });
        }
	});
});