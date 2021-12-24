Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.Data.Filtering

Namespace ASPxDashboard_CustomFilterExpression
	Partial Public Class WebForm1
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ASPxDashboard1.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Dashboards"))
		End Sub

		Protected Sub ASPxDashboard1_CustomFilterExpression(ByVal sender As Object, ByVal e As CustomFilterExpressionWebEventArgs)
			If e.DataSourceConnectionName = "nwindConnection" AndAlso e.TableName = "Invoices" Then
				e.FilterExpression = New BinaryOperator("CustomerID", "AROUT", BinaryOperatorType.Equal)
			End If
		End Sub
	End Class
End Namespace