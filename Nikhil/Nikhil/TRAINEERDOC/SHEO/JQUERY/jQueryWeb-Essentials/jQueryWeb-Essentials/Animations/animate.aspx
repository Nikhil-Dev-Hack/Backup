<%@ Page Title="jQuery Animations - animate demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="animate.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Animations - animate demo</h3>

        <p>Click on Animate button</p>
  
        <input type="button" value="Animate" id="btnAnimate" />

        <p id="pAnimate" style="background-color:Green;">Animate This</p>

        <script >

            $("#btnAnimate").click(function () {
                $("#pAnimate").animate({
                    width: "800px",
                    fontSize: "60px",
                    height: "500px"
                }, "slow"); // instead of 500, we can also keep "slow", "fast"
            });

        </script>
        <!-- START - Navigations Links -->
        <hr />
        <p>
            <a href="Default.aspx" title="Back to Manipulations">Back to Animations</a> |
            <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a>
        </p>
        <!-- END - Navigations Links -->
</asp:Content>
