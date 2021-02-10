<%@ Page Title="jQuery Events - change demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="change.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Events - change demo</h3>
        Try to change the drop down item
        <p>
            <select id="dropChange">
                <option>Change() demo</option>
                <option>Select Me</option>
                <option>Me as well</option>
            </select>
        </p>

        <script language="javascript" type="text/javascript">

            $("#dropChange").change(function () {
                alert("Change handler called");
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
