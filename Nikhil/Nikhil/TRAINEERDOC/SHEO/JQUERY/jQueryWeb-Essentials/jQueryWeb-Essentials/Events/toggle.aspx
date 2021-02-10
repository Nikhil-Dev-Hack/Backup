<%@ Page Title="jQuery Events - toggle demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="toggle.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Events - toggle demo</h3>
        
    <p>Try to click below text several times.</p>

    <div id="divToggle" style="cursor:pointer;border:1px solid #546898;">
        Try clicking me several times</div>
    
    <script language="javascript" type="text/javascript">

        $("#divToggle").toggle(function () {
            $(this).css("background", "red");
        },
        function () {
            $(this).css("background", "green");
        },
        function () {
            $(this).css("background", "yellow");
        },
        function () {
            $(this).css("background", "");
        },
        function () {
            $(this).css("background", "blue");
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
