<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="Jquery.Ajax.Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ajax Demo</title>
    <script src="../Scripts/jquery-3.5.1.min.js"></script>

</head>
<body>
    <p>Click on the button and wait for results</p>

    <input type="button" name="bntAjax" value="Load data using jquery" id="btnAjax" />

    OutPut:
    <div id="divResult"></div>

    <script type="text/javascript">
        $("#btnAjax").click(function () {
            $.ajax({
                type: "POST",
                url: "AjaxData.aspx",
                data: "a=2&b=5",
                success: function (msg) {
                    $("#divResult").text(msg);
                }
            });
        });
    </script>
    
</body>
</html>
