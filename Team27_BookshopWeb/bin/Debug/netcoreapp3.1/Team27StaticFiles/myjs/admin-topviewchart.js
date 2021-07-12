$(document).ready(function () {
    $.ajax({
        url: '/admin/ThongKe/TopViewChart',
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
        data.addColumn('string', 'BookName');
        data.addColumn('number', 'Count');
        var dataArray = [];
        $.each(result, function (i, obj) {
            dataArray.push([obj.bookName, parseInt(obj.count)]);
        });

        data.addRows(dataArray);

        var piechart_options = {
            title: 'Biểu đồ tròn lượt xem của sách',
            width: 400,
            height: 300
        };
        var piechart = new google.visualization.PieChart(document.getElementById('piechart_div'));
        piechart.draw(data, piechart_options);
    }
});

