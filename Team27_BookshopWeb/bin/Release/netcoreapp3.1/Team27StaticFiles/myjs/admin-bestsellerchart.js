$(document).ready(function () {
    $.ajax({
        url: '/admin/ThongKe/BestSellerChart',
        data: {
            day: $("select#day").val()
        },
        dataType: "json",
        type: "GET",
        contentType: "application/json",

        success: function (result) {
            google.charts.load('current', {
                'packages': ['corechart']
            });
            google.charts.setOnLoadCallback(function () {
                drawChart(result);
            });
        }
    });
    function drawChart(result) {
        var data = new google.visualization.DataTable();
        data.addColumn('string', 'Tên sách');
        data.addColumn('number', 'Số lượng đã bán');
        var dataArray = [];
        $.each(result, function (i, obj) {
            dataArray.push([obj.bookName, parseInt(obj.numberOfBooks)]);
        });

        data.addRows(dataArray);

        var barchart_options = {
            title: 'Biểu đồ cột thống kê top 10 sách bán chạy nhất',
            width: 700,
            height: 300
        };
        var piechart = new google.visualization.BarChart(document.getElementById('barchart_div'));
        piechart.draw(data, barchart_options);
    }
});

