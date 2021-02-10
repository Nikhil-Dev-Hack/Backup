function FirstFunction() {
    alert("Called from first function");
    SecondFunction();
}

$("#btnJquery").click(function () {
    alert("Called from first function");
    SecondFunction();
});

function addJavascript(jsname) {
    var th = document.getElementsByTagName('head')[0]
    var s = document.createElement('script')
    s.setAttribute('type', 'text/javascript')
    s.setAttribute('src', jsname)
    th.appendChild(s)
}
addJavascript('/include/Silverlight.js');