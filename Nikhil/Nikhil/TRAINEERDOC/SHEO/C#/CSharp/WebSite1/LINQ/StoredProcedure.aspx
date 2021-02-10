<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StoredProcedure.aspx.cs" Inherits="LINQ_StoredProcedure" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>
                Get data from Personal details table
            </legend>
            <asp:TextBox ID="txtAutoId" runat="server" />
            <asp:RequiredFieldValidator ID="Req1" runat="server" Text="*" ControlToValidate="txtAutoId" Display="Static" />
            <asp:Button ID="nbtn" runat="server" Text="Submit" OnClick="SubmitData" />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        </fieldset>
        <asp:GridView ID="GridView1" runat="server" EnableViewState="false" />
    </div>
    </form>
</body>
</html>
