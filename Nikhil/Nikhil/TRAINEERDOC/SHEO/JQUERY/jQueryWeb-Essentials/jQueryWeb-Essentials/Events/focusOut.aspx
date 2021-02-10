<%@ Page Title="jQuery Events - focusout demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="focusOut.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Events - focusout demo</h3>
    <p>Try to keep focus out of the textboxes.</p>

    <p id="pFocusOut" style="background:Yellow">focusout demo : 
        <input type="text" id="txtFocusOut" /><br />
        <input type="text" id="txtFocusOut1" /><br />
    </p>

    <div id="div3">
    </div>
    <script language="javascript" type="text/javascript">

        $("#txtFocusOut, #txtFocusOut1").focusout(function () {
            alert("got focus out");
        });

        $("#txtFocusOut, #txtFocusOut1").blur(function () {
            alert("raised blur event");
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
