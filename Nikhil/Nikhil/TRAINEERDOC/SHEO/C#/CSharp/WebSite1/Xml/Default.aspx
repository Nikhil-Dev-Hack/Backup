<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Xml_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" />

        <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="Read" />
    </div>
    </form>
</body>
</html>
