<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="TwoJsFiles_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Two .js file</title>
     <!-- START - jQuery Reference -->
    <script type="text/javascript" language="Javascript" src="../Script/jquery-1.4.1.min.js"></script>
    <script type='text/javascript'>//<![CDATA[
        if (typeof jQuery == 'undefined') {
            document.write(unescape("%3Cscript src='../Script/jquery-1.4.1.min.js' type='text/javascript' %3E%3C/script%3E"));
        }//]]>
    </script>
    <!-- END - jQuery Reference -->

</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <input type="button" id="btnButton" onclick="FirstFunction()" value="Click Me Please !" />
        <input type="button" id="btnJquery" value="jQuery = Click Me Please !" />
        <div id="divClick"></div>


    </div>
    </form>
    
    
    <script language="javascript" type="text/javascript" src="First.js"></script>
    <script language="javascript" type="text/javascript" src="Second.js"></script>



</body>
</html>
