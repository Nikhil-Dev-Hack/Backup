<%@ Page Title="jQuery Animations - fadein & fadeout demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="fadeinout.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Animations - fadein & fadeout demo</h3>

    <p>Click on Fade In and Fade Out buttons</p>

    <p>
        <input type="button" id="btnFadeIn" value="Fade In" />
        <input type="button" id="btnFadeout" value="Fade Out" />
    </p>

    <div id="divFadeIn" style="height: 50px; width: 50px; background: red; left: 0px;display: none; position: absolute;"></div>

    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <script >

        $("#btnFadeIn").click(function () {
            $("#divFadeIn").fadeIn();
            // $("#divFadeIn").fadeIn('100');
        });

        //- Fadeout - fade out the specified element
        $("#btnFadeout").click(function () {
            // $("#divFadeIn").fadeOut();
            $("#divFadeIn").fadeOut('slow');
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
