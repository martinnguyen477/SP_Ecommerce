$(document).ready(function () {
    //Validator for phone
    jQuery.validator.addMethod('valid_phone', function (value) {
        var regex = /^0{1}\d{9}$/;
        return value.trim().match(regex);
    });
    //Validator for email
    jQuery.validator.addMethod('valid_email', function (value) {
        var regex = /^[\w]{1,}[\w.+-]{0,}@[\w-]{2,}([.][a-zA-Z]{2,}|[.][\w-]{2,}[.][a-zA-Z]{2,})$/;
        return value.trim().match(regex);
    });

    $("#profile-update").validate({
        rules: {
            Name: {
                required: true
            },
            Birthdate: {
                required: true
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
                    url: '/admin/Profile/EmailVerify',
                    data: {
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
            Birthdate: {
                required: "Ngày sinh không được trống",
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

    $(document).on("click", "#btn-update-profile", function (e) {
        e.preventDefault();
        if ($("#profile-update").valid()) {
            //Nếu dữ liệu đã valid
            // Lấy giá trị của form
            $("#profile-update").submit();
        }
    });

    //Validate
    $("#change-password").validate({
        rules: {
            CurrentPassword: {
                required: true,
                remote: {
                    type: 'post',
                    url: '/admin/Profile/PasswordCheck',
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

    // Edit customer's password info AJAX
    $(document).on("click", "#change-password .btnUpdatePw", function (e) {
        e.preventDefault();
        if ($("#change-password").valid()) {
            //Nếu dữ liệu đã valid
            // Lấy giá trị của form
            var form = $("#change-password");
            var id = form.data("id");
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
                url: '/admin/Profile/EditPassword',
                type: 'post',
                dataType: 'json',
                data: data,
                success: function (response) {
                    var res = JSON.parse(JSON.stringify(response));
                    if (res.isSuccess) {	//Cập nhật thành công
                        // Cập nhật thông tin
                        $('#change-password input#CurrentPassword').val("");
                        $('#change-password input#NewPassword').val("");
                        $('#change-password input#PasswordConfirmation').val("");
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