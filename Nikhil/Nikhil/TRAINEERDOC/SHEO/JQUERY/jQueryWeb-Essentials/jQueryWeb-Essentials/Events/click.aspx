<%@ Page Title="jQuery Events - click demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="click.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>
        jQuery Events - click demo</h3>

        <span>Click the button</span>
    
        <p>
            <input type="button" id="btnClick" value="Click() demo - click me" />
        </p>

        <span>2nd Span: Click the button</span>

        <script language="javascript" type="text/javascript">

            $("#btnClick").click(function () {
                alert($(this).val());
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
