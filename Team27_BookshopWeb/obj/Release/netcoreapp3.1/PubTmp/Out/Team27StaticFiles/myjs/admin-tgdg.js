$(document).ready(function () {
    // Kiểm tra và tạo slug
	$(document).on("change", 'input.Name', function(e){
        // GET trong AJAX
        var col = $(this).closest("td");
        var source = $(this).val();
        var id = $(this).closest("tr").find(".ID h6").text();
        if (id === undefined) id = "";
        if (source != "") {
            $.get("/admin/AuthorTranslator/CheckSlug",
                {
                    source: source,
                    id: id
                },
                function (reponse) {
                    col.find("input.Slug").val(reponse);
                }
            );
        }
    });

	// Button Sửa
	$(document).on("click", ".item.btnSua", function(){
		$(this).parent().find(".btnHuy").css('display', 'block');
		$(this).parent().find(".btnLuu").css('display', 'block');
		$(this).css('display', 'none');


		// Get this row
		var row = $(this).closest("tr");
		// Allow modify Author's name
		row.find("input[name='Name']").removeAttr('readonly');
	});

	// Button Lưu sau khi sửa
	$(document).on("click", ".item.btnLuu", function(){
		// Get this row
		var row = $(this).closest("tr");
		row.find("span.error-name").remove();
		// Get ID or this author/translator
		var Id = row.find(".ID h6").text();
		var Name = row.find("input.Name").val();
		var Slug = row.find("input.Slug").val();
		var Author, Translator;
        Author = (row.find('.ckb_au').is(":checked")) ? 1 : 0;
        Translator = (row.find('.ckb_trans').is(":checked")) ? 1 : 0;

		var data = {
			Id : Id,
			Name: Name,
			Slug: Slug,
            Author: Author,
            Translator: Translator,
        };
        if (Name == "") {
            $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> Họ tên tác giả hoặc dịch giả không được trống.</div>');
            return;
        }

        if (Author == 0 && Translator == 0) {
			$('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> Yêu cầu phải là tác giả hoặc dịch giả.</div>');
		}
		else {
			$.ajax({
				url: '/admin/AuthorTranslator/Edit',
				type: "put",	
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(data),
				success: function(response){
					var res = JSON.parse(JSON.stringify(response));
                    if (res.isSuccess) { //Thay đổi thành công
                        ChangeDisplayData(row, res.data);

						row.find("input.Slug").after($('<span class = "error-name" style="color: #4EBE38;">Chỉnh sửa thành công</span>'));
						// Show alert success
	                	$('.table-responsive.table-responsive-data3').prepend('<div class="alert-box success"><span>success: </span> Chỉnh sửa thành công</div>');
					}
					else {
						row.find("input.Slug").after($('<span class = "error-name" style="color: red;">Chỉnh sửa thất bại</span>'));
                        $.each(res.messages, function (index, value) {
                            // Show alert error
                            $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> ' + value + '</div>');
                        });
					}
				},
				error: function(error){
                    console.log(error);
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

	// Button Thoát chỉnh sửa
	$(document).on("click", ".item.btnHuy", function(){
		$(this).css('display', 'none');
		$(this).parent().find(".btnLuu").css('display', 'none');
		$(this).parent().find(".btnSua").css('display', 'block');
		
		$(document).find(".alert-box").remove();

		// Get this row
		var row = $(this).closest("tr");

		// Not Allow modify Author's name
		row.find("input[name='Name']").attr('readonly', true);

		// Remove error in this tr
        row.find("span.error-name").remove();

        //Load lại dữ liệu
        var Id = row.find(".ID h6").text();
        var Name = row.find("input.Name");
        var data = {
            Id: Id
        };
        $.ajax({
            url: '/admin/AuthorTranslator/Detail',
            dataType: "json",
            data: data,
            success: function (response) {
                var res = JSON.parse(JSON.stringify(response));
                if (res.isSuccess) { //Load thành công
                    ChangeDisplayData(row, res.data);
                }
                else {
                    $.each(res.messages, function (index, value) {
                        // Show alert error
                        $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> ' + value + '</div>');
                    });
                }
            },
            error: function (error) {
                console.log(error);
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
	});

	// Button Thêm mới
	$(document).on("click", ".item.btnThem", function(){
        var row = $(this).closest("tr");
        var Name = row.find("input.Name");
        var Slug = row.find("input.Slug");
        var ckb_au = row.find("input.Author");
        var ckb_trans = row.find("input.Translator");
        var Translator, Author;

        // Remove error
        row.find("span.error-name").remove();

        Author = (row.find('.ckb_au').is(":checked")) ? 1 : 0;
        Translator = (row.find('.ckb_trans').is(":checked")) ? 1 : 0;
        var data = {
            Name: Name.val(),
            Slug: Slug.val(),
            Author: Author,
            Translator: Translator,
        };
        if (Name.val() == "") {
            $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> Họ tên tác giả hoặc dịch giả không được trống.</div>');
        }
        else if (Author == 0 && Translator == 0) {
            $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> Yêu cầu phải là tác giả hoặc dịch giả.</div>');
        }
        else {
            $.ajax({
                url: '/admin/AuthorTranslator/Create',
                type: "post",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(data),
                success: function (response) {
                    var res = JSON.parse(JSON.stringify(response));
                    if (res.isSuccess) { //Thêm thành công
                        // Reset
                        row.find("input.Name").val("");
                        row.find("input.Slug").val("");
                        row.find('.ckb_au').prop('checked', false);
                        row.find('.ckb_trans').prop('checked', false);

                        if ($(document).find("button.au-btn.au-btn-load.js-load-btn").length == 0) {
                            LoadPage(0);
                        }

                        // Show alert success
                        $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box success"><span>success: </span> Thêm thành công.</div>');
                    }
                    else {
                        $.each(res.messages, function (index, value) {
                            // Show alert error
                            $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> ' + value + '</div>');
                        });
                    }
                },
                error: function (error) {
                    console.log(error);
                }
            });
        }	
    });

	// Button Tạm xóa
	$(document).on("click", ".item.btnXoa", function(){
		var row = $(this).closest("tr");
		var Id = row.find(".ID h6").text();
        var Name = row.find("input.Name");
        var data = {
            Id: Id
        };
        //Confirm bằng sweet alert
        Swal.fire({
            title: "Xóa tác giả/dịch giả này?",
            text: "Bạn có chắc chắn muốn xóa tác giả/ dịch giả " + Name.val() + " không ?",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Không',
            confirmButtonText: 'Có, hãy xóa!'
        }).then((result) => {
            if (result.isConfirmed) {
                if (Id == "") {
                    $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> Mã tác giả/dịch giả không được trống. Xóa thất bại.</div>');
                }
                else {
                    $.ajax({
                        url: '/admin/AuthorTranslator/SoftDelete',
                        type: "delete",
                        dataType: "json",
                        data: data,
                        success: function (response) {
                            var res = JSON.parse(JSON.stringify(response));
                            if (res.isSuccess) { //Xóa thành công
                                // Xóa dòng dữ liệu trong table
                                row.remove();
                                //Sweet alert khi thành công
                                Swal.fire({
                                    position: 'center',
                                    icon: 'success',
                                    title: 'Tác giả/dịch giả đã được xóa',
                                    showConfirmButton: false,
                                    timer: 1000
                                });
                            }
                            else {
                                $.each(res.messages, function (index, value) {
                                    // Show alert error
                                    $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> ' + value + '</div>');
                                });
                            }
                        },
                        error: function (error) {
                            console.log(error);
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
            }
        })
    });

    // Button Khôi phục và Xóa hoàn toàn
    $(document).on("click", ".item.btnRestore, .item.btnDeleteForever", function () {
        var row = $(this).closest("tr");
        var Id = row.find(".ID h6").text();
        var Name = row.find("input.Name");
        var data = {
            Id: Id
        };
        var actionDesc = "Xóa";
        var action = "Delete";
        if ($(this).hasClass("btnRestore")) {
            actionDesc = "Khôi phục";
            action = "Restore";
        }
        //Confirm bằng sweet alert
        Swal.fire({
            title: actionDesc + " tác giả/dịch giả này?",
            text: "Bạn muốn " + actionDesc + " tác giả/ dịch giả " + Name.val() + " không ? ",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Không',
            confirmButtonText: 'Có'
        }).then((result) => {
            if (result.isConfirmed) {
                if (Id == "") {
                    $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> Mã tác giả/dịch giả không được trống. Xóa thất bại.</div>');
                }
                else {
                    $.ajax({
                        url: '/admin/AuthorTranslator/' + action,
                        dataType: "json",
                        contentType: "application/json",
                        data: data,
                        success: function (response) {
                            var res = JSON.parse(JSON.stringify(response));
                            if (res.isSuccess) { //Khôi phục thành công
                                // Xóa dòng dữ liệu trong table
                                row.remove();
                                //Sweet alert khi thành công
                                Swal.fire({
                                    position: 'center',
                                    icon: 'success',
                                    title: 'TTác giả/dịch giả đã được ' + actionDesc,
                                    showConfirmButton: false,
                                    timer: 1000
                                });
                            }
                            else {
                                $.each(res.messages, function (index, value) {
                                    // Show alert error
                                    $('.table-responsive.table-responsive-data3').prepend('<div class="alert-box error"><span>error: </span> ' + value + '</div>');
                                });
                            }
                        },
                        error: function (error) {
                            console.log(error);
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
            }
        })
    });

    //Button Hủy tìm kiếm
    $(document).on("click", ".searchbox button#btnReset", function () {
        //Reset text box search
        $("input[name='Search']").val("");
        //Submit form tìm kiếm
        $(this).form.submit();
    });

    //Button Load more
    $(document).on("click", ".au-btn-load", function (e) {
        var page = parseInt($(this).data("page"));
        $(this).closest("tr").remove();
        LoadPage(page);
    });
});

function LoadPage(page) {
    $.ajax({
        url: window.location.href,
        dataType: "html",
        data: {
            page: page
        },
        success: function (response) {
            if (response != null) {
                $("#table-authors-translators").append(response);
            }
        },
        error: function (error) {
            console.log(error);
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

function ChangeDisplayData(row, data) {
    row.find("input.Name").val(data.displayName);
    row.find("input.Slug").val(data.slug);
    if (data.author == 1) row.find('.ckb_au').prop('checked', true);
    else row.find('.ckb_au').prop('checked', false);

    if (data.translator == 1) row.find('.ckb_trans').prop('checked', true);
    else row.find('.ckb_trans').prop('checked', false);
}