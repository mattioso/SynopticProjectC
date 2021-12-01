
function Search() {
    data = {
        "RouteId": document.getElementById("RouteId").value,
        "StatusId": document.getElementById("StatusId").value,
        "LevelId": document.getElementById("LevelId").value,
        "DurationId": document.getElementById("DurationId").value
    }

    $.post("Internal/GetTableData",
        data,
        function (data, status) {
            alert("Data: " + data + "\nStatus: " + status);
        });
}