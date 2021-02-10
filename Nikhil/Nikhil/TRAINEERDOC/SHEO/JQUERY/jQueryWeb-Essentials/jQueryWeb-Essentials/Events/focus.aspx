<%@ Page Title="jQuery Events - focus demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="focus.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Events - focus demo</h3>
    <p>Try to keep focus in the textboxes.</p>

    <p id="pFocus" style="background:Yellow">focus demo : 
        <input type="text" id="txtFocus" /><br />
        <input type="text" id="txtFocus1" /><br />
    </p>

    <div id="div3">
    </div>
    <script language="javascript" type="text/javascript">

        $("#txtFocus, #txtFocus1").focus(function () {
            alert("Got focus");
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
