var i = 0;

importScripts("AnotherScriptFile1.js");

function GetDateTime() {
    i++;

    if (i == 5)
    {
        postMessage(i + " : " + new Date() + " : " + AlertMeFromOtherFile());
    }
    else
    {
        postMessage(i + " : " + new Date());
    }
    setTimeout("GetDateTime()", 1000);
}

GetDateTime();