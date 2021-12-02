
var data = null
var showTable = false;

$(window).resize(function () {
    CreateTable();
});

function CreateTable() {
    if (showTable) {
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
                        return `<a href="${data}" target="_blank">${data}</a>`
                    }
                }
            ]
        });
    }
}

function Search() {
    input_data = {
        "RouteId": document.getElementById("RouteId").value,
        "StatusId": document.getElementById("StatusId").value,
        "LevelId": document.getElementById("LevelId").value,
        "DurationId": document.getElementById("DurationId").value
    }
    $("#error-alert").hide();
    $("#error-alert").empty();

    showTable = true;

    if (input_data.RouteId == -1 && input_data.StatusId == -1 && input_data.LevelId == -1 && input_data.DurationId == -1) {
        $("#error-alert").append("<p>Please Select an option from one of the dropdowns</p>");
        $("#error-alert").show();
    }
    else {
        $("#results").show();
        $.post("Internal/GetTableData",
            input_data,
            function (server_data, status) {
                data = server_data;
                CreateTable();
            });
    }

}