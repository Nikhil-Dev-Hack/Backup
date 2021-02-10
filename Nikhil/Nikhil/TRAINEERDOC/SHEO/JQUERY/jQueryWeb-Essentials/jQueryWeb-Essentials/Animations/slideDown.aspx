<%@ Page Title="jQuery Animations - slideDown demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="slideDown.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Animations - slideDown demo</h3>
    
    <p>Click on slideDown button</p>

    <p><input type="button" id="btnSlideDown" value="SlideDown" /></p>

    <div id="divSlideDown" style="height: 50px; width: 50px; background: brown; left: 0px;
        position: absolute; display: none;">
    </div>

    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <script language="javascript" type="text/javascript">

        $("#btnSlideDown").click(function () {
            $("#divSlideDown").slideDown();
            // $("#divSlideDown").slideDown("slow", QueueIt);
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
