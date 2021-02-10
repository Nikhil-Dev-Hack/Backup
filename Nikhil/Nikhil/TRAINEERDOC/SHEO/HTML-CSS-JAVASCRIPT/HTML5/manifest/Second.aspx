<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Second.aspx.cs" Inherits="Manifest_Second" %>

<!DOCTYPE HTML>
<html manifest="/manifest/Manifest.ashx">
<body>
    <h1>Second Page</h1>
    <p>
    <a href="Default.aspx">First Page</a>
    </p>
    <asp:Label ID="lblMessage" runat="server" />
</body>
</html>