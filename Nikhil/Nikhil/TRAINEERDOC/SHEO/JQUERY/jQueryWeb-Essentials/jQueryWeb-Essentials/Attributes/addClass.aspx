<%@ Page Title="jQuery AddClass Attribute demo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addClass.aspx.cs" Inherits="Attributes_addClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <style>

        .h3Class
        {
            color:red;
            background-color:green;
        }

    </style>

    <h3>jQuery AddClass Attribute demo</h3>   
    
    <div id="div1">DIV 1: First div content</div>

    <div id="myDiv">
        <p>Paragraph 1</p>
        <p>Paragraph 2</p>
        <p>aragraph 3</p>
    </div>

    <div id="div2" class="class1">Demo of <b>attr</b> attribute</div>

    <div id="div3">
        Div 3</div>
        <div id="div4" style="color:Red;">Div 4</div>

    <input type="button" id="btnToggleClass" value="Toggle Class" />
    
    <script>
        $(function () {

            //$("#div2").attr("class", "h3Class");

            var className = $("#div2").attr("class");
            alert(className);

             $("h3").addClass("h3Class");
              $("#div1").addClass("class2");

             $("#myDiv p:nth-child(2)").addClass("class2");

        });
    </script>

<!-- START - Navigations Links -->
<hr />
<p><a href="Default.aspx" title="Back to Attributes">Back to Attributes</a> | <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a> </p>
<!-- END - Navigations Links -->
</asp:Content>

