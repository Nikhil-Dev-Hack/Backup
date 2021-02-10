<%@ Page Title="jQuery Events - dblClick demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="dblClick.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Events - dblClick demo</h3>

        DblClick the button
   
        <p>
            <input type="button" id="btnDblClick" value="DblClick() demo - double click me" />
        </p>

        <script language="javascript" type="text/javascript">

            $("#btnDblClick").dblclick(function () {
                alert("dblclick event called");
            });

        </script>
        <!-- START - Navigations Links -->
        <hr />
        <p>
            <a href="Default.aspx" title="Back to Manipulations">Back to Events</a> |
            <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a>
        </p>
        <!-- END - Navigations Links -->
</asp:Content>
