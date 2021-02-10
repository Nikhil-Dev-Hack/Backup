<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateXML.aspx.cs" Inherits="XML_CreateXML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMessage" runat="server" EnableViewState="false" />
        <asp:Button ID="btnCreate" runat="server" Text="Create XML File" OnClick="CreateXMLFile" />
    </div>
    </form>
</body>
</html>
