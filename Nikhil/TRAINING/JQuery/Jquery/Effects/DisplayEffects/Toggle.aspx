<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Toggle.aspx.cs" Inherits="Jquery.Effects.DisplayEffects.Toggle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../../Scripts/jquery-3.5.1.min.js"></script>

    <title>Toggle</title>
</head>
<body>
   <%-- <p class="Toggle">This is about the Toggle Effect</p>

    <input type="button" name="btnToggle" value="Toggle"  id="btnToggle"/>

    <script>
        $("#btnToggle").click(function () {
            $("p:Toggle").toggleClass();
        });
    </script>--%>


    <script>    
        $(document).ready(function () {
            $("button").click(function () {
                $("div.d1").toggle();
            });
        });
    </script>    

  
<button>Toggle</button>    
<div class="d1" style="border:1px solid black;padding:10px;width:250px">    
<p><b>This is a little poem: </b><br/>      
Twinkle, twinkle, little star<br/>      
How I wonder what you are<br/>      
Up above the world so high<br/>      
Like a diamond in the sky<br/>      
Twinkle, twinkle little star<br/>      
How I wonder what you are</p>     
</div>    
</body>
</html>
