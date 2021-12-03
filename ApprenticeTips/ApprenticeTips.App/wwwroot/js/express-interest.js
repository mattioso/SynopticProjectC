
const regex = new RegExp('^[0-9 ]+$')

function OnSubmitPressed() {
    data = {
        "FirstName": document.getElementById("FirstName").value,
        "Surname": document.getElementById("Surname").value,
        "Email": document.getElementById("Email").value,
        "PhoneNumber": document.getElementById("PhoneNumber").value,
        "PreviousQualificationsLevel": document.getElementById("PreviousQualificationsLevel").value,
        "Agriculture": document.getElementById("Agriculture").checked,
        "Business": document.getElementById("Business").checked,
        "Care": document.getElementById("Care").checked,
        "Catering": document.getElementById("Catering").checked,
        "Construction": document.getElementById("Construction").checked,
        "Creative": document.getElementById("Creative").checked,
        "Digital": document.getElementById("Digital").checked,
        "Education": document.getElementById("Education").checked,
        "Engineering": document.getElementById("Engineering").checked,
        "Hair": document.getElementById("Hair").checked,
        "Health": document.getElementById("Health").checked,
        "Legal": document.getElementById("Legal").checked,
        "Protective": document.getElementById("Protective").checked,
        "Sales": document.getElementById("Sales").checked,
        "Transport": document.getElementById("Transport").checked,
        "Comments": document.getElementById("Comments").value
    }

    var dataValid = true;
    $("#error-alert").empty()

    if (data.FirstName == "") {
        dataValid = false;
        $("#error-alert").append("<p>Please enter a First Name</p>")
    }

    if (data.Surname == "") {
        dataValid = false;
        $("#error-alert").append("<p>Please enter a Surname</p>")
    }

    if (data.Email == "") {
        dataValid = false;
        $("#error-alert").append("<p>Please enter an Email</p>")
    }

    if (data.PhoneNumber == "") {
        dataValid = false;
        $("#error-alert").append("<p>Please enter a Phone Number</p>")
    }
    else if (!regex.test(data.PhoneNumber)) {
        dataValid = false;
        $("#error-alert").append("<p>Please enter a valid Phone Number</p>")
    }

    if ([data.Agriculture,
        data.Business,
        data.Care,
        data.Catering,
        data.Construction,
        data.Creative,
        data.Digital,
        data.Education,
        data.Engineering,
        data.Hair, data.Health,
        data.Legal,
        data.Protective,
        data.Sales,
        data.Transport].every(v => v === false)) {
        dataValid = false;
        $("#error-alert").append("<p>Please select at least one pathway</p>")
    }
    
    if (dataValid) {
        $.post("Interest/GetInterestData",
            data,
            function (data, status) {
                if (status == "success" && data.success) {
                    window.location.href = "/Interest/Thanks";
                }
                else if (status != "success") {
                    $("#error-alert").empty();
                    $("#error-alert").append("<p>There has been an issue connecting to the server, please try again later</p>")
                    $("#error-alert").show();
                }
                else {
                    $("#error-alert").empty();
                    $("#error-alert").append(`<p>${data.error}</p>`)
                    $("#error-alert").show();
                }
            });
    }
    else {
        $("#error-alert").show();
    }

}