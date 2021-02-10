<%@ Page Title="jQuery Animations - SlideUp demo" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="slideup.aspx.cs" Inherits="Events_blur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>jQuery Animations - SlideUp demo</h3>

    <p>Click on SlideUp button</p>
    
    <p><input type="button" id="btnSlideUp" value="SlideUp" /></p>

    <div id="divSlideUp" style="height: 50px; width: 50px; background: brown; left: 300px;
        position: absolute; display: ;">
    </div>

    <script language="javascript" type="text/javascript">

        $("#btnSlideUp").click(function () {
             $("#divSlideUp").slideUp("slow");
            
            //$("#divSlideUp").slideUp("slow", FireFunction);
        });

        function FireFunction() {
            alert("Slideup completed.");
        }

    </script>
    <!-- START - Navigations Links -->
    <hr />
    <p>
        <a href="Default.aspx" title="Back to Manipulations">Back to Animations</a> | <a
            href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a>
    </p>
    <!-- END - Navigations Links -->
</asp:Content>
