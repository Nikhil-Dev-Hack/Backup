<%@ Page Title="jQuery html Attribute demo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="html.aspx.cs" Inherits="Attributes_addClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <h3>jQuery html Attribute demo</h3>   
    <div>First div content</div>
    <p>Paragraph 1</p>
    <p>Paragraph 2</p>
    <p>Paragraph 3</p>

    <div id="div2" class="class1">
        Demo of some <b>jQuery</b> Attributes
    </div>
    
    DIV 3
    <div id="div3">Div 3</div>



    <div id="div4" style="color:Red;">Div 4</div>

    <input type="button" id="btnToggleClass" value="Toggle Class" />
    
    <script>
        
        $(function () {
            
            alert($("#div2").html());

            $("#div3").html("This is a good <b>boy</b>");

        });

    </script>

<!-- START - Navigations Links -->
<hr />
<p><a href="Default.aspx" title="Back to Attributes">Back to Attributes</a> | <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a> </p>
<!-- END - Navigations Links -->
</asp:Content>

