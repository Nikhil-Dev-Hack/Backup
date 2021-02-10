<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Folders.aspx.cs" Inherits="FilesFolders_Folders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Working with Folders</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Directory nane:
            <asp:TextBox ID="txtName" runat="server" />
            <asp:Button runat="server" Text="Create" ID="btnCreate" OnClick="btnCreate_Click" />
            <asp:Button runat="server" Text="Rename" ID="Rename" OnClick="Rename_Click" />

            <asp:Label ID="lblMessage" runat="server" EnableViewState="false" />

            <hr />
            <span onclick="return confirm('Are you sure to deltete?')">
                <asp:Button ID="btnDelete" runat="server" Text="Delete" ForeColor="Red" OnClick="btnDelete_Click" />
            </span>
            <hr />
            <asp:Button ID="btnList" runat="server" Text="List Folders" OnClick="btnList_Click" />
            <asp:Button ID="btnListFiles" runat="server" Text="List Files" OnClick="btnListFiles_Click" />
            <asp:Literal runat="server" ID="litMessage" EnableViewState="false" />

        </div>
    </form>
</body>
</html>
