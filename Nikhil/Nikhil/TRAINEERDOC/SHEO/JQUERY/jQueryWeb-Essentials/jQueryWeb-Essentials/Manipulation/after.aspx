<%@ Page Title="jQuery manipulation - after demo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="after.aspx.cs" Inherits="Manipulation_before" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <h3>jQuery manipulation - after demo</h3> 
    <br />
    <h1>H1: jQuery Manipulations</h1>
    
    <div>
            <p>Paragraph 1</p>
            <p>Paragraph 2</p>
            <p>Paragraph 3</p>
            <p class="class1">Class 1 - P</p>
        </div>
        <div id="div2" class="class1">
            Demo text</div>
            <hr />
        <div id="div3">Div 3</div>
    
    <div id="divScroll" style="height:100px;width:300px;overflow:scroll;">
        <p id="divP" style="height:300px;width:500px;background:#efefef;">
            This is looking nice.
        </p>
    </div>

    <script language="javascript" type="text/javascript">
        $("h1").after("<h2>This should be the sub heading</h2>");
    </script>        

<!-- START - Navigations Links -->
<hr />
<p><a href="Default.aspx" title="Back to Manipulations">Back to Manipulations</a> | <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a> </p>
<!-- END - Navigations Links -->
</asp:Content>

