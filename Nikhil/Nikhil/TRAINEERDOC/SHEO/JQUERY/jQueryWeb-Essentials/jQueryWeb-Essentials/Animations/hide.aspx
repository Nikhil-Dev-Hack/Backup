<%@ Page Title="jQuery Animations - hide demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="hide.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Animations - hide demo</h3>

    <p>Click on Hide button</p>

    <p><input type="button" id="btnHide" value="Hide" /></p>

    <div id="divHide" style="height: 50px; width: 50px; background: red; left: 0px; position: absolute;"></div>
    
    <p>&nbsp;</p><p>&nbsp;</p>
    <script language="javascript" type="text/javascript">

        $("#btnHide").click(function () {
            $("#divHide").hide("medium");
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
