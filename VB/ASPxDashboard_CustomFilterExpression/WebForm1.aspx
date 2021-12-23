<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" Inherits="ASPxDashboard_CustomFilterExpression.WebForm1" %>
<!DOCTYPE html>

<html>
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div style="position: absolute; top: 0; left: 0; right: 0; bottom: 0;">
		<dx:ASPxDashboard ID="ASPxDashboard1" runat="server" Width="100%" Height="100%" 
			OnCustomFilterExpression="ASPxDashboard1_CustomFilterExpression" 
			WorkingMode="Viewer">
		</dx:ASPxDashboard>
	</div>
	</form>
</body>
</html>