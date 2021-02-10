<%@ Page Title="jQuery traversing - children demo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="children.aspx.cs" Inherits="Traversing_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <h3>jQuery traversing - children demo</h3>   
    
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
        </div>

        <p class="class1">Class 1 - P</p>

        <div id="div2" class="class1">Demo of traversing
            <p>
                This is the children of Div 2
            </p>
         </div>

            <hr />

        <div id="div3">This is the text directly into Div 3</div>
    
    <p><span>Look:</span> <span>This is some text in a paragraph.</span> <span>This is a note about it.</span></p>
    
     <script language="javascript" type="text/javascript">

         $(function () {

             $("ul").children().css("background", "red");

         });

    </script>

<!-- START - Navigations Links -->
<hr />
<p><a href="Default.aspx" title="Back to Attributes">Back to Attributes</a> | <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a> </p>
<!-- END - Navigations Links -->
</asp:Content>

