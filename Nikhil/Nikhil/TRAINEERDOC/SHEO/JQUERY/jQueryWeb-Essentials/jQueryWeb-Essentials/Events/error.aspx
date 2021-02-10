<%@ Page Title="jQuery Events - error demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Events - error demo</h3>

        As the image doesn't exsits so it alert the user.
        <p> error demo : 
        <img src="http://www.dotnetfunda.com/images/DotNetLogo.gif" id="imgError" /></p>

    <script language="javascript" type="text/javascript">

        $("#imgError").error(function () {
            alert("missing image");
        });

        // http://www.dotnetfunda.com/images/DotNetLogo.gif

    </script>
    <!-- START - Navigations Links -->
    <hr />
    <p>
        <a href="Default.aspx" title="Back to Manipulations">Back to Events</a> |
        <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a>
    </p>
    <!-- END - Navigations Links -->
</asp:Content>
