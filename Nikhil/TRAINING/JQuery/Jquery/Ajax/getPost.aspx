<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getPost.aspx.cs" Inherits="Jquery.Ajax.getPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>getPost</title>
    <script src="../Scripts/jquery-3.5.1.min.js"></script>

</head>
<body>

    <input type="button" id="btnPost" value="1. Load Data using Post" />

    <input type="button" id="btnGet" value="2. Load Data using Get" />

    <input type="text" name="btnText" placeholder="Enter a number" id="btnText"/>

    Result:
    <div id="divResult"></div>

    <script>
        $("#btnPost").click(function () {
            $.post("AjaxData.aspx", { a: "#btnText", b: "49" }, function (data) { $("#divResult").html("The result is " + data); });
        });

        $("#btnGet").click(function () {
            $.get("AjaxData.aspx", { ag: "2", bg: "6" }, function (data) { $("#divResult").html("<b>The result is: " + data + "</b>"); });
        });
    </script>

</body>
</html>
