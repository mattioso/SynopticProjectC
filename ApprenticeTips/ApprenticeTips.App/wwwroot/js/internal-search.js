
function Search() {
    data = {
        "RouteId": document.getElementById("RouteId").value,
        "StatusId": document.getElementById("StatusId").value,
        "LevelId": document.getElementById("LevelId").value,
        "DurationId": document.getElementById("DurationId").value
    }
    $("#error-alert").hide();
    $("#error-alert").empty();

    if (data.RouteId == -1 && data.StatusId == -1 && data.LevelId == -1 && data.DurationId == -1) {
        $("#error-alert").append("<p>Please Select an option from one of the dropdowns</p>");
        $("#error-alert").show();
    }
    else {
        $("#results").show();
        $.post("Internal/GetTableData",
            data,
            function (data, status) {
                $("#table-div").empty()
                $('#table-div').append('<table id="search-table"></table>')

                $('#search-table').DataTable({
                    "data": JSON.parse(data),
                    "iDisplayLength": 50,
                    "columns": [
                        { "data": "Name" },
                        {
                            "data": "Link",
                            "render": function (data, type) {
                                return `<a href="${data}">${data}</a>`
                            }
                        }
                    ]
                })
            });
    }

}