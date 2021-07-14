$(document).ready(function() {
	// Thêm phân quyền
	$(document).on('click', '#btnAdd', function(){
		var NhanvienID = $('tfoot tr').find('select[name=nhanvien_add]').val();
		var Xem = $('tfoot tr').find('input.ckb_xem.add').is(':checked');
		var Them = $('tfoot tr').find('input.ckb_them.add').is(':checked');
		var Xoa = $('tfoot tr').find('input.ckb_xoa.add').is(':checked');
		var Sua = $('tfoot tr').find('input.ckb_sua.add').is(':checked');

		$.ajax({
			url: 'phanquyen/create',
			type: 'post',
			dataType: 'json',
			data: {
					'NhanvienID' : NhanvienID,
					'Xem' : Xem,
					'Them' : Them,
					'Xoa' : Xoa,
					'Sua' : Sua
					},
			success: function(response){
				var res = JSON.parse(JSON.stringify(response));
				if (res.err == "") {
					// Hiện alert
					$('.sufee-alert.alert.with-close.alert-danger.alert-dismissible').css('display', 'block');
					$('span.badge.badge-pill.badge-danger').html("Thành công");
					// Chèn message vào alert
					$('.sufee-alert.alert.with-close.alert-danger.alert-dismissible #message-alert').html('Phân quyền thành công');
					$('table.table tbody').append(res.success);
					$('select[name=nhanvien_add] option[value="' + NhanvienID + '"]').remove();
					if ($('select[name=nhanvien_add] option').length == 0) {
					    $('tfoot').remove();
					}
					$('tr#empty').remove();
					$('input.add').prop('checked', false);
				}
				else {
					// Hiện alert
					$('.sufee-alert.alert.with-close.alert-danger.alert-dismissible').css('display', 'block');
					$('span.badge.badge-pill.badge-danger').html("Lỗi");
					// Chèn message vào alert
					$('.sufee-alert.alert.with-close.alert-danger.alert-dismissible #message-alert').html(res.err);
				}
			},
			error: function(req, err) {	console.log('Không nhận được dữ liệu' + err); }
		});
	});

	$(document).on('click', '.more', function(){
		var cur_tr = $(this).parents("tr:first");
		var id = cur_tr.find('div.ID h6').text();
		var Xem = cur_tr.find('input.ckb_xem').is(':checked');
		var Them = cur_tr.find('input.ckb_them').is(':checked');
		var Xoa = cur_tr.find('input.ckb_xoa').is(':checked');
		var Sua = cur_tr.find('input.ckb_sua').is(':checked');

		$.ajax({
			url: 'phanquyen/update',
			type: 'post',
			dataType: 'json',
			data: {
					'NhanvienID' : id,
					'Xem' : Xem,
					'Them' : Them,
					'Xoa' : Xoa,
					'Sua' : Sua
					},
			success: function(response){
				var res = JSON.parse(JSON.stringify(response));
				if (res.err == "") {
					// Hiện alert
					$('.sufee-alert.alert.with-close.alert-danger.alert-dismissible').css('display', 'block');
					$('span.badge.badge-pill.badge-danger').html("Thành công");
					// Chèn message vào alert
					$('.sufee-alert.alert.with-close.alert-danger.alert-dismissible #message-alert').html('Cập nhật thành công');
					
				}
				else {
					// Hiện alert
					$('.sufee-alert.alert.with-close.alert-danger.alert-dismissible').css('display', 'block');
					$('span.badge.badge-pill.badge-danger').html("Lỗi");
					// Chèn message vào alert
					$('.sufee-alert.alert.with-close.alert-danger.alert-dismissible #message-alert').html(res.err);
					if (res.Xem == 0) {
						cur_tr.find('input.ckb_xem').prop('checked', false);
					}
					else {
						cur_tr.find('input.ckb_xem').prop('checked', true);	
					}

					if (res.Xoa == 0) {
						cur_tr.find('input.ckb_xoa').prop('checked', false);
					}
					else {
						cur_tr.find('input.ckb_xoa').prop('checked', true);	
					}

					if (res.Them == 0) {
						cur_tr.find('input.ckb_them').prop('checked', false);
					}
					else {
						cur_tr.find('input.ckb_them').prop('checked', true);	
					}

					if (res.Sua == 0) {
						cur_tr.find('input.ckb_sua').prop('checked', false);
					}
					else {
						cur_tr.find('input.ckb_sua').prop('checked', true);	
					}
				}
			},
			error: function(req, err) {	console.log('Không nhận được dữ liệu' + err); }
		});
	});
});