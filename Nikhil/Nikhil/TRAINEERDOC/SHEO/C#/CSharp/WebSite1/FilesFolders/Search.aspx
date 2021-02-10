<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="FilesFolders_Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Files</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="Default.aspx">Create Files</a>
        <h2>Search Files</h2>
        <asp:TextBox ID="txtName" runat="server" />
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <hr />
        <asp:Literal runat="server" ID="litList" EnableViewState="false" />
    </div>
    </form>
</body>
</html>
