<%@ Page Title="Element Selector" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="ElementSelector.aspx.cs" Inherits="Selectors_AllSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<h3>Element Selectors</h3>    
    <div>
        <p id="p1">
            jQuery selector is used to select a particular type of element or element of a particular
            Id, or class used</p>
        <p class="class1">
            Class - jQuery selector is used to select a particular type of element or element
            of a particular Id, or class used</p>
    </div>
    <div id="div2">
        <p>Paragraph 1</p>
        <p>Paragraph 2</p>
        <p>Paragraph 3</p>
    </div>

    <input id="txtName" type="text" />

    <script>

        $(function () {

            $("div").css("border", "5px solid green");

        });

    </script>

<!-- START - Navigations Links -->
<hr />
<p><a href="Default.aspx" title="Back to Selectors">Back to Selectors</a> | <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a> </p>
<!-- END - Navigations Links -->
</asp:Content>
