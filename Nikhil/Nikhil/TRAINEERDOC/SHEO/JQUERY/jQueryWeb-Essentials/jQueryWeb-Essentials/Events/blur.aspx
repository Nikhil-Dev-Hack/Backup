<%@ Page Title="jQuery Events - blur demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="blur.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Events - blur demo</h3>

        Focus on the textbox and click tab
        <p>
            <input type="text" id="txtBlur" value="Blur() Demo - Tab out" />
        </p>


        <script language="javascript" type="text/javascript">

            $("#txtBlur").blur(function () {
                AlertMePlease();
            });

            function AlertMePlease() {
                alert("Blur handler called.");
            }

        </script>

        <!-- START - Navigations Links -->
        <hr />
        <p>
            <a href="Default.aspx" title="Back to Manipulations">Back to Events</a> |
            <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a>
        </p>
        <!-- END - Navigations Links -->
</asp:Content>
