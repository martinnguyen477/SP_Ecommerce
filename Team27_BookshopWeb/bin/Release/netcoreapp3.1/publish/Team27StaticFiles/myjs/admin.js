$(document).ready(function() {
	$('.close#alert-close').on('click', function(){
		// Đóng alert
		$('.sufee-alert.alert.with-close').css('display', 'none');
	});

	/**
	 * Toggle thống kê theo tháng/năm
	 */
	$(document).on('click', '#statistic_search_form input[name="statistic_type"]', function(event) {
		var statisticType = $(this).val();
		checkSelectMonthYear(statisticType);
	});
});

/**
 * [checkSelectMonthYear Hiển thị form phù hợp với loại thống kê đã chọn]
 * @param  {[string]} statisticType [Loại thống kê]
 */
function checkSelectMonthYear(statisticType){
	if (statisticType == 'year'){
		$('#select_month').attr('style', 'display:none;');
		$('#select_month').find('*').attr('disabled', "disabled");
	}
	else {
		$('#select_month').attr('style', 'display:block;');
		$('#select_month').find('*').removeAttr("disabled");
	}
}