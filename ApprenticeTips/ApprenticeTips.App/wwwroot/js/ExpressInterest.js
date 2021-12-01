
function OnSubmitPressed() {
    data = {
        "FirstName": document.getElementById("FirstName").value,
        "SecondName": document.getElementById("Surname").value,
        "Email": document.getElementById("Email").value,
        "ContactNumber": document.getElementById("PhoneNumber").value,
        "LevelOfPreviousQual": document.getElementById("PreviousQualificationsLevel").value,
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

    console.log(data)

    $.post("Interest/GetInterestData",
           data,
           function (data, status) {
               alert("Data: " + data + "\nStatus: " + status);
           });
}