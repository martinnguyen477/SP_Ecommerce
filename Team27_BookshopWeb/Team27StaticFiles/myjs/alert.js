$(document).ready(function() {
	// Bấm vào alert để tắt alert
	$(document).on('click', '.alert-box', function(event) {
		$(this).remove();
	});

    //Đóng alert
    $('.close#alert-close').on('click', function () {
        $('.sufee-alert.alert.with-close').attr('style', 'display:none');
        $('.sufee-alert.alert.with-close.alert-dismissible').removeClass("alert-success alert-danger");
        $('span.badge.badge-pill').removeClass("badge-success badge-danger");
    });

	// Hiện tooltip khi hover vào alert
	$(document).on('mouseenter', '.alert-box', function(event) {
		$(this).append("<div class = 'tooltiptext'>Nhấp để đóng thông báo</div>");
	}).on('mouseleave', '.alert-box', function(event) {
		$(this).find(".tooltiptext").remove();
    });

});

//Show alert with close
function ShowAlertWithClose(type, messageText) {
    var className = "", title = "", classRemove = "";
    switch (type) {
        case "error":
            className = "danger";
            classRemove = "success";
            title = "Lỗi";
            break;
        default:
            className = "success";
            classRemove = "danger";
            title = "Thành công";
            break;
    }
    // Hiện alert
    $('.sufee-alert.alert.with-close.alert-dismissible').attr("style", "display:block");
    $('.sufee-alert.alert.with-close.alert-dismissible').addClass("alert-" + className + " show");
    $('span.badge.badge-pill').addClass("badge-" + className);
    //Xóa class cũ
    $('.sufee-alert.alert.with-close.alert-dismissible').removeClass("alert-" + classRemove);
    $('span.badge.badge-pill').removeClass("badge-" + classRemove);
    $('span.badge.badge-pill').html(title);
    // Chèn message vào alert
    $('.sufee-alert.alert.with-close.alert-dismissible #message-alert').html(messageText);
}

function confirmDelete(url, text) {
	Swal.fire({
		title: "Xóa",
		text: text,
		icon: 'warning',
		showCancelButton: true,
		confirmButtonColor: '#3085d6',
		cancelButtonColor: '#d33',
		cancelButtonText: 'Không',
		confirmButtonText: 'Có, hãy xóa!'
	}).then((result) => {
		if (result.isConfirmed) {
			window.location.href = url;
		}
	})
}