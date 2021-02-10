<%@ Page Title="jQuery Events - EventXEventY demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="eventXeventY.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Events - EventXEventY demo</h3>
    
    Move mouse in the yellow area.
    
    <p id="pEventXEventY" style="height: 200px; width: 300px; background-color: Yellow;">
        eventX and eventY test</p>

    <script language="javascript" type="text/javascript">

        $("#pEventXEventY").bind("mousemove", function (e) {
            $(this).text("pageX: " + e.pageX + " pageY: " + e.pageY);
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
