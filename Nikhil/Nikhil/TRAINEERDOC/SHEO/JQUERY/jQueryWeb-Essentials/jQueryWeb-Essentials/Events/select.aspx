<%@ Page Title="jQuery Events - select demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="select.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Events - select demo</h3>        

    <div id="divSelect" style="cursor:pointer;background:yellow;">Click here to select below text</div>
    
    <p>
        <textarea id="txtAreaSelect" cols="20" rows="5">Try selecting this text</textarea>
    </p>

    <div id="div3">Close</div>

    <script language="javascript" type="text/javascript">

        $("#txtAreaSelect").select(function () {
            alert("You are trying to select");
        });

        $("#divSelect").click(function () {
            $("#txtAreaSelect").select();
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
