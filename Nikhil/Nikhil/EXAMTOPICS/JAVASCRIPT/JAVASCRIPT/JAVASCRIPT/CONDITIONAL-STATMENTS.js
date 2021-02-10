//IF STATMENT
function IFStatment() {
    var Name = document.getElementById("txtC").value;
    if (Name == "Nikhil") {
        alert("Hello["+Name+"]");
    }
    else if (Name == "Nikhil Banuri") {
        alert("Enter");
    }
    else {
        alert("Enter A Nikhil");
    }
}

//SWITCH STATMENT

function SwitchStatment() {
    var Name = "Nik"
    switch (Name) {
        case "Nikki":
            alert("Good");
        case "Nikhil":
            alert("Brillaent");
        default:
            alert("Idiot");
            break;
    }

}

