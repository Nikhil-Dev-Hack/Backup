<%@ Page Title="Webmethod from jQuery" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CallingWebMethod.aspx.cs" Inherits="Ajax_CallingWebMethod" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p style="color:Blue;">Go to ItFunda.Com for jQuery training.</p>
    Website name: <asp:TextBox ID="txtBoxName" runat="server" ClientIDMode="Static" />
        
        <button id="btnAjax">Call web service using $.Ajax</button>

        <h3>Result from web service</h3>
        <div id="divResult"></div>

        <script language="javascript" type="text/javascript">
            
            $("#btnAjax").click(function () {
                var webServiceUrl = "../MathService.asmx/GetFullName";
                var name = $("#txtBoxName").val();
                $.ajax({
                    type: "POST",
                    url: webServiceUrl,
                    data: "{'name':'"+ name + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: SuccessCallBack,
                    error: FailureCallBack
                });
            });

            function SuccessCallBack(data) {
                alert(data.d);
            }

            function FailureCallBack(data) {
                alert(data.staus + " : " + data.statusText);
            }

    </script>
</asp:Content>

