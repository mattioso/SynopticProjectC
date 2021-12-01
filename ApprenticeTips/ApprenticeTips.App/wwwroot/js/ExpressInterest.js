
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
    
    if (dataValid) {
        $.post("Interest/GetInterestData",
            data,
            function (data, status) {
                alert("Data: " + data + "\nStatus: " + status);
            });
    }
    else {
        $("#error-alert").show();
    }

}