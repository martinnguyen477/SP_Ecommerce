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

    //Validate register form
    $("#register-form").validate();
    //Validate register email
    $("#Register_Email").rules("add", {
        remote: {
            type: 'post',
            url: '/User/EmailVerify',
            data: {
                'email': function () { return $('#Register_Email').val(); },
            },
            dataType: 'json'
        }
    });

    //Validate register email
    $("#Register_Phone").rules("add", {
        valid_phone: true,
        messages: {
            valid_phone: "Số điện thoại không hợp lệ"
        }
    });

    //Validate register username
    $("#Register_Username").rules("add", {
        remote: {
            type: 'post',
            url: '/User/UsernameVerify',
            data: {
                'username': function () { return $('#Register_Username').val(); },
            },
            dataType: 'json'
        }
    });

    //Validate login form 
    $("#login-form").validate();
    //Validate login username
    $("#Login_Username").rules("add", {
        required: true,
        messages: {
            required: "Tên đăng nhập không được trống"
        }
    });

    //Validate login passwor
    $("#Login_Password").rules("add", {
        required: true,
        messages: {
            required: "Mật khẩu không được trống"
        }
    });

    //Validation create customer form
    $("#customer-create-form").validate({
        rules: {
            Password: {
                required: true
            }
        },
        messages: {
            Password: {
                required: "Mật khẩu không được trống"
            }
        }
    });

    
});