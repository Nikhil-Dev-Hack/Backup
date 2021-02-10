<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListPage.aspx.cs" Inherits="ArrayList_ListPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List Data</title>
    <style>
        body{
            font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        }
        table{
            width:100%;
        }
        th{
            background-color:blue;
            color:yellow;
            padding:5px;
        }
        table, tr, td
        {
            border-collapse:collapse;
            border:1px solid #c0c00c;
            padding:5px;
        }
        tr:nth-child(2n+1){
            background-color:#ff6a00;
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" EnableViewState="false" />
    </div>
    </form>
</body>
</html>
