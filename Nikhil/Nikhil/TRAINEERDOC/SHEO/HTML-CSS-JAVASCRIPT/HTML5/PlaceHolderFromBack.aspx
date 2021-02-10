<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PlaceHolderFromBack.aspx.cs" Inherits="PlaceHolderFromBack" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <input type="text" placeholder='<%= _placeHolder %>' id="txt1" name="txt1" />

            <div>
                <input type="text" list="list1" id="tx1" name="tx1" />
                <datalist id="list1">
                    <%= _list%>
                </datalist>
            </div>
    </div>
    </form>
</body>
</html>
