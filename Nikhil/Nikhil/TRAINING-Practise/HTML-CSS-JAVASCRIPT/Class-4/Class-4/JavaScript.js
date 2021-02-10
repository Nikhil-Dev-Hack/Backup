function ValidateTheForm() {
    if (document.getElementById("txtFirstName").value == '') {
        alert("Please specify first name, it is mandatory !");
        return false;
    }
    else if (document.getElementById("txtLastName").value == '') {
        alert("Please specify Last name, it is mandatory !");
        return false;
    }
    else {
        return true;
    }
}