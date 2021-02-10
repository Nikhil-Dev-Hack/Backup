<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getJSON.aspx.cs" Inherits="Jquery.Ajax.getJSON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../Scripts/jquery-3.5.1.min.js"></script>
    <title>getJSON</title>
</head>
<body>
    <p>cLICK ON THE BUTTON</p>

    <input type="button" name="btJson" value="Load Json" id="btnJson" />

    <script>
        $("#btnJson").click(function () {
            $.getJSON("AjaxData.aspx", { comingFrom: "jsonPage", j: "myJSonSample" }, jsonCallback);
        });

        function jsonCallback(datas) {
            alert(datas[0].FirstName);
        }
    </script>

</body>
</html>
