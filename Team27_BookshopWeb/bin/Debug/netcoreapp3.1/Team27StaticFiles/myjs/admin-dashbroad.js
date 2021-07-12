$(document).ready(function () {
    $.ajax({
        url: '/admin/Dashboard/OrderTypeChart',
        data: {
            time: $("select#time").val()
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
        data.addColumn('string', 'Tình trạng đơn hàng');
        data.addColumn('number', 'Số lượng đơn hàng');
        var dataArray = [];
        $.each(result, function (i, obj) {
            dataArray.push([obj.orderTypeName, parseInt(obj.count)]);
        });

        data.addRows(dataArray);

        var piechart_options = {
            title: 'Biểu đồ đường của đơn hàng',
            width: 500,
            height: 380,
            chartArea:{
                width: '90%'
            },
            colors: ['#b0120a', '#7b1fa2'],
            hAxis: {
                title: 'Tình trạng đơn hàng'
            },
            vAxis: {
                title: 'Số lượng đơn hàng'
            }  
        };
        var piechart = new google.visualization.AreaChart(document.getElementById('piechart_div'));
        piechart.draw(data, piechart_options);
    }
});

