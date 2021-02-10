<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        A <asp:TextBox ID="txtA" runat="server" /> / B <asp:TextBox ID="txtB" runat="server" />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblResult" runat="server" EnableViewState="false" />
        <hr />
        <p>
            <asp:Label ID="lblMessage" runat="server" EnableViewState="false" />
        </p>
    </div>
    </form>
</body>
</html>
