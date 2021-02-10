<%@ Page Title="jQuery Events - submit demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="submit.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Events - submit demo</h3>
        
    <p>Try to click on the Submit buton.</p>

    <input type="text" id="txtSubmit" /> <br />

    <div id="divSubmit"></div>

    <input type="submit" id="btnSubmit" value="Submit" />
    
    <script language="javascript" type="text/javascript">

        $("form").submit(function () {
            $("#divSubmit").fadeIn("fast").text("You have tried to submit the form.").delay(500).fadeOut("slow");
            return false;
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
