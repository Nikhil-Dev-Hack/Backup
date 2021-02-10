<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="FilesFolders_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h2>File Management</h2>
            <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" Rows="10" Columns="80" />
            <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txtContent"
                Text="Please write content." />
            <br />
            <asp:Button ID="btnCreate" runat="server" EnableViewState="false" OnClick="btnCreate_Click" Text="Create" />
            <asp:Button ID="btnUpdate" runat="server" EnableViewState="false" OnClick="btnUpdate_Click" Text="Append" />

            <span onclick="return confirm('Are you sure to delete?')">
                <asp:Button ID="btnDeletete" runat="server" EnableViewState="false"
                      CausesValidation="false"
                     OnClick="btnDeletete_Click" Text="Delete" />
            </span>

            <p>
                <asp:Label ID="lblMessage" runat="server" EnableViewState="false" ForeColor="Green" />
            </p>
            <hr />
            <p>
                <asp:Button ID="btnRead" runat="server" EnableViewState="false" OnClick="btnRead_Click" Text="Read" CausesValidation="false" /></p>
            <asp:Literal runat="server" ID="litContent" EnableViewState="false" />
            <hr />
            Change name of :
            <asp:TextBox ID="txtName" runat="server" />
            to
            <asp:TextBox ID="txtNameTo" runat="server" />
            <asp:Button ID="btnChangeName" runat="server" Text="Change Name" OnClick="btnChangeName_Click" />

    </div>
    </form>
</body>
</html>
