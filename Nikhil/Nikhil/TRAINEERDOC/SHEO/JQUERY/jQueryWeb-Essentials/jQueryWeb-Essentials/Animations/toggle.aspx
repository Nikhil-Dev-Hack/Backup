<%@ Page Title="jQuery Animations - toggle demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="toggle.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Animations - toggle demo</h3>

    <p>Toggle demo: <input type="button" id="btnToggle" value="Toggle" /></p>

    <div id="divToggle" style="height: 50px; width: 50px; background: brown; left: 300px;
        position: absolute;">
    </div>

    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <script  type="text/javascript">

        $("#btnToggle").click(function () {
            $("#divToggle").toggle("slow");
        });

        // $("#btnToggle").toggle(function () {
        //$("#divToggle").slideUp();
        //}, function () {
        //$("#divToggle").slideDown();
        //});

    </script>
    <!-- START - Navigations Links -->
    <hr />
    <p>
        <a href="Default.aspx" title="Back to Manipulations">Back to Animations</a> | <a
            href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a>
    </p>
    <!-- END - Navigations Links -->
</asp:Content>
