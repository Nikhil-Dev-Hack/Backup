<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Manifest_Default" %>

<!DOCTYPE HTML>
<html manifest="/manifest/Manifest.ashx">
<body>
    <h1>First Page</h1>
    <p>
        <a href="Second.aspx">Second Page</a>
    </p>
    <asp:Label ID="lblMessage" runat="server" />
</body>
</html>