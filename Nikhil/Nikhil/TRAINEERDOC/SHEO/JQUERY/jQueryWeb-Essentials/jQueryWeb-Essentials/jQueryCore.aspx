<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jQueryCore.aspx.cs" Inherits="jQueryCore" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>jQuery Core</title>

    <style type="text/css">
        body {
            font-family: Verdana, Arial;
            font-size: 10pt;
        }
    </style>

    <!-- START - jQuery Reference -->
    <script type="text/javascript" language="Javascript" src="https://code.jquery.com/jquery-3.5.1.min.js"></script>

    <script type='text/javascript'>//<![CDATA[
        if (typeof jQuery == 'undefined') {
            document.write(unescape("%3Cscript src='/Script/jquery-1.4.1.min.js' type='text/javascript' %3E%3C/script%3E"));
        }//]]>
    </script>
    <!-- END - jQuery Reference -->

    <script language="javascript" type="text/javascript">

        $(function () {

            $("div").css("border", "2px solid red");

        });

    </script>

</head>
<body>
    <form id="form1">
        <h1 class="h1Class">jQuery Core</h1>
        <br />
        <div id="div1">
            jQuery is a fast and concise JavaScript Library that simplifies HTML document traversing,
        event handling, animating, and Ajax interactions for rapid web development.
        </div>
        <div>Another div</div>
    </form>



</body>
</html>
