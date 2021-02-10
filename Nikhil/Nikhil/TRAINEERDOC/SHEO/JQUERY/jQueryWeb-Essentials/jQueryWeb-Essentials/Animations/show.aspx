<%@ Page Title="jQuery Animations - show demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="show.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Animations - show demo</h3>
    <p>Click on show button</p>

    <p><input type="button" id="btnShow" value="Show" /></p>

    <div id="divShow" style="height: 50px; width: 50px; background: brown; left: 0px;position: absolute; display: none;"></div>

    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>

    <script language="javascript" type="text/javascript">

        $("#btnShow").click(function () {
            $("#divShow").show("slow");
            // $("#divShow").show("slow", QueueIt);
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
