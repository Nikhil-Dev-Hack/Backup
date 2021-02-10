<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HideAndShow.aspx.cs" Inherits="Jquery.Effects.DisplayEffects.HideAndShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../../Scripts/jquery-3.5.1.min.js"></script>


    <title>Show And Hide</title>
</head>

<body>

    <p id="hidep" style="color:red">Click Hide button to hide &amp Click Show button to show  </p>
       


    <button id="hide">Hide</button>
    <button id="show">Show</button>

    <script>  
        $(document).ready(function () {
            $("#hide").click(function () {
                $("#hidep").hide();
            });
            $("#show").click(function () {
                $("#hidep").show();
            });
        });
    </script>
</body>
</html>
