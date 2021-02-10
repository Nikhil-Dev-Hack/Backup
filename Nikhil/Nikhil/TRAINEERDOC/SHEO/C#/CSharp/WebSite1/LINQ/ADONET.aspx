<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADONET.aspx.cs" Inherits="LINQ_ADONET" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
        <asp:GridView ID="GridView1" runat="server" EnableViewState="false" AllowPaging="false" PageSize="55" />
        <asp:Button runat="server" ID="fdsa" Text="Insert" OnClick="InsertRecord" />
        <asp:Button runat="server" ID="Button1" Text="Update" OnClick="UpdateRecord" />
        <asp:Button runat="server" ID="Button2" Text="Delete" OnClick="DeleteRecord" />
    </div>
    </form>
</body>
</html>
