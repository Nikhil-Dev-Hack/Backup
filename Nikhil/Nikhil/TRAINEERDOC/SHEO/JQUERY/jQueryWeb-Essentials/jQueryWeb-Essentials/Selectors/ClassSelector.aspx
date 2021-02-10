<%@ Page Title="Class Selector" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="ClassSelector.aspx.cs" Inherits="Selectors_AllSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<h3>Class Selectors</h3>    
    <div>
        <p id="p1">
            jQuery selector is used to select a particular type of element or element of a particular
            Id, or class used</p>
        
        <p class="class1">
            Class 1 - jQuery selector is used to select a particular type of element or element
            of a particular Id, or class used</p>

    </div>
    <div id="div2">
        <p>Paragraph 1</p>
        <p>Paragraph 2</p>
        <p>Paragraph 3</p>
    </div>

    <span id="txtName">Span</span>

    <input id="txtName" type="text" />

    <input id="txtName1" type="text" />
    
    <script>

        $(function () {

            // $("p.class1, #p1").css("border", "5px solid green");

            $('input[id$="txtName"]').val('My data');

        });

    </script>

<!-- START - Navigations Links -->
<hr />
<p><a href="Default.aspx" title="Back to Selectors">Back to Selectors</a> | <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a> </p>
<!-- END - Navigations Links -->
</asp:Content>
