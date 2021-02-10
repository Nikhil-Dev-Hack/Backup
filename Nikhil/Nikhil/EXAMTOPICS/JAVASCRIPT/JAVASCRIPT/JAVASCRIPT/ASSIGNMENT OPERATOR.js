function Add(a,b) {
    var sum = a + b;
    return sum;
}


//CONFIRMATION BOX


function ConfirmMe() {
    var v = confirm("Are you sure") 
    if (v) {
        alert("GO Ahead");
    }
    else {
        alert("stop");
    }
}

// PROMPT BOX


function Prompt() {
    var p = prompt("What is your name")
    if (p != null && p != "") {
        alert("Your name is["+p+"]");
    }
}