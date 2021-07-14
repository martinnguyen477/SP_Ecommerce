$(document).ready(function () {
    //choose rating
    $(document).on("change", "#comment-form input[name='Vote']", function () {
        //unchecked all 
        $("#comment-form input[name='Vote']").removeAttr("check");
        //check chosen rating
        $(this).attr("check", true);
    });

    //Submit nhận xét
    $(document).on("submit", "#comment-form", function (e) {
        e.preventDefault();
        //get data
        var data = {
            BookId: $(this).find("input[name='BookId']").val(),
            Vote: $(this).find("input[name='Vote']:checked").val(),
            Content: $(this).find("textarea[name='Content']").val(),
            Name: $(this).find("input[name='Name']").val(),
            Email: $(this).find("input[name='Email']").val(),
        };
        $.ajax({
            url: '/ProductDetails/Comment',
            type: 'POST',
            dataType: 'json',
            data: data
        })
        .done(function (response) {
            var res = JSON.parse(JSON.stringify(response));
            console.log("success");
            if (res.isSuccess) {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Cảm ơn quý khách đã đánh giá cho sách này',
                    showConfirmButton: 'Đóng',
                }).then((result) => {
                    if (result.isConfirmed) {
                        location.reload();
                    }
                    else {
                        location.reload();
                    }
                });
                    
            }
            else {
                Swal.fire({
                    position: 'center',
                    icon: 'error',
                    title: 'Xảy ra lỗi, vui lòng thử lại',
                    showConfirmButton: 'Đóng'
                })
            }
                
        })
        .fail(function (error) {
            console.log(error);
            Swal.fire({
                icon: "error",
                title: 'Lỗi',
                text: 'Lỗi không thể nhận xét sách',
                type: 'error',
                confirmButtonText: 'Đóng'
            })
        });
    });
});