<%@ Page Title="Validate for numbers only" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ValidateForNumbers.aspx.cs" Inherits="Howto_ValidateForNumbers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h3>Restrict only numbers in the text box</h3>

Age: <input type="text" id="txtNumber" />
    <input type="button" id="btnValidate" value="Validate Integer" />

    <script language="javascript" type="text/javascript">
        $("#btnValidate").click(function () {
            if ($('#txtNumber').val() != "") {
                var value = $('#txtNumber').val().replace(/^\s\s*/, '').replace(/\s\s*$/, '');
                var intRegex = /^\d+$/;
                if (!intRegex.test(value)) {
                    alert("Please write numbers only");
                    // you can return false
                }
                else {
                    // you can return true
                    alert("You entered: " + $("#txtNumber").val());
                }
            } else {
                alert("Please enter your age");
                // you can return false
            }
        });
    </script>

<!-- START - Navigations Links -->
<hr />
<p><a href="Default.aspx" title="Back to How to">Back to Back to How to</a> | <a href="../" title="Back to jQuery Demo Home">Back to jQuery Demo Home</a> </p>
<!-- END - Navigations Links -->

</asp:Content>

