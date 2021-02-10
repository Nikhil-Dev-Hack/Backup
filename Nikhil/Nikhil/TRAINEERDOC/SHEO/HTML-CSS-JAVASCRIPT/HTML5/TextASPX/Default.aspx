<%@ Page Language="C#" %>
<script language="C#" runat="Server">
void Page_Load(object sender, EventArgs e)
{
lblMessage.Text = "Hello World !";
}
</script>
<html>
<head>
<title>First ASP.NET page written in Notepad</title>
</head>
<body>
	This bis something
<asp:Label ID="lblMessage" runat="Server" />
<asp:Label ID="lblTest" runat="Server" Text="Something something" />
</body>
</html>