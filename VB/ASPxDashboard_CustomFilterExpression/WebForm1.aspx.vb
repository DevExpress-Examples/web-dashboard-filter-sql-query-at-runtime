Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.Data.Filtering

Namespace ASPxDashboard_CustomFilterExpression

    Public Partial Class WebForm1
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxDashboard1.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Dashboards"))
        End Sub

        Protected Sub ASPxDashboard1_CustomFilterExpression(ByVal sender As Object, ByVal e As CustomFilterExpressionWebEventArgs)
            If Equals(e.DataSourceConnectionName, "nwindConnection") AndAlso Equals(e.QueryName, "Invoices") Then
                e.FilterExpression = New BinaryOperator("Customers.CompanyName", "Around the Horn", BinaryOperatorType.Equal)
            End If
        End Sub
    End Class
End Namespace
