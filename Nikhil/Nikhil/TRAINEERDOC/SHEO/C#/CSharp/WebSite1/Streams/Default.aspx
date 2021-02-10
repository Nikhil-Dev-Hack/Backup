<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Streams_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p><asp:Button ID="btnSubmit" runat="server" Text="Create a Text file" OnClick="CreateATextFile" />
                <asp:Button ID="Button1" runat="server" Text="Read a Text file" OnClick="ReadATextFile" />
            </p>
        </div>


        <asp:Literal ID="lblMessage" runat="server" EnableViewState="false" />

    </form>
</body>
</html>
