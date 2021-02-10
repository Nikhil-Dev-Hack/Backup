<%@ Page Title="jQuery traversing - parent demo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="parent.aspx.cs" Inherits="Traversing_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <h3>jQuery traversing - parent demo</h3>   
    
    <div>
            <ul>
                <li>First</li>
                <li>Second</li>
                <li>Third</li>
                <li>Fourth</li>
            </ul>
            <p>
                Paragraph 1
            </p>
            <p>      
                Paragraph 2
            </p>
            <p>
                Paragraph 3
            </p>
            <p class="class1">Class 1 - P</p>
        </div>
        <div id="div2" class="class1">
            Demo of traversing </div>
            <hr />
        <div id="div3">
        </div>
    
    <p><span>Look:</span> <span>This is some text in a paragraph.</span> <span>This is a note about it.</span></p>
    
     <script language="javascript" type="text/javascript">
         
         $(function () {

             $("ul").parent().css("border", "2px solid green");

         });

    </script>

<!-- START - Navigations Links -->
<hr />
<p><a href="Default.aspx" title="Back to Attributes">Back to Attributes</a> | <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a> </p>
<!-- END - Navigations Links -->
</asp:Content>

