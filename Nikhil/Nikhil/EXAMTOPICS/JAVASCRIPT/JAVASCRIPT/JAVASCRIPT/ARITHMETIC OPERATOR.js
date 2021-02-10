// ARITHMETIC OPERATOR

function Sum() {
    var a = document.getElementById("txtA").value;
    var b = document.getElementById("txtB").value;
    var result = parseInt(a) + parseInt(b);
    alert(result);
}

function Subtract() {
    var a = document.getElementById("txtA").value;
    var b = document.getElementById("txtB").value;
    var result = parseInt(a) - parseInt(b);
    alert(result);
}

function Multiply() {
    var a = document.getElementById("txtA").value;
    var b = document.getElementById("txtB").value;
    var result = parseInt(a) * parseInt(b);
    alert(result);
}

function Divide() {
    var a = document.getElementById("txtA").value;
    var b = document.getElementById("txtB").value;
    var result = parseInt(a) / parseInt(b);
    alert(result);
}

function Reminder() {
    var a = document.getElementById("txtA").value;
    var b = document.getElementById("txtB").value;
    var result = parseInt(a) % parseInt(b);
    alert(result);
}