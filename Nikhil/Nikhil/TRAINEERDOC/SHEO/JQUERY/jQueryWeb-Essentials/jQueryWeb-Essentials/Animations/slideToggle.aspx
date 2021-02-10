<%@ Page Title="jQuery Animations - slideToggle demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="slideToggle.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Animations - slideToggle demo</h3>
    <p>Click on slideToggle button again and again</p>

    <p><input type="button" id="btnSlideToggle" value="SlideToggle" /></p>

    <div id="divSlideToggle" style="height: 50px; width: 50px; background: brown; left: 0px;position: absolute; display: none;"></div>

    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <script language="javascript" type="text/javascript">

        $("#btnSlideToggle").click(function () {
            $("#divSlideToggle").slideToggle();
            // $("#divSlideToggle").slideToggle("slow", QueueIt);
        });

    </script>
    <!-- START - Navigations Links -->
    <hr />
    <p>
        <a href="Default.aspx" title="Back to Manipulations">Back to Animations</a> | <a
            href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a>
    </p>
    <!-- END - Navigations Links -->
</asp:Content>
