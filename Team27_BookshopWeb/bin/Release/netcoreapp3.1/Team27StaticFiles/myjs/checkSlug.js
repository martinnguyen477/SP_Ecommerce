function checkSlug(source, route) {
    $(document).on("change", '#' + source, function (e) {
        var id = $('input[name="Id"]').val();
        if (id === undefined) id = "";
        if ($(this).val() != "") {
            // GET trong AJAX
            $.get(route,
                {
                    source: $(this).val(),
                    id: id
                },
                function (data) {
                    $('#Slug').val(data);
                }
            );
        }
    });
}