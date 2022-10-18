<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579849/21.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T479085)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for Web Forms - How to filter an SQL query at runtime

The following example shows how to use the [ASPxDashboard.CustomFilterExpression](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomFilterExpression) event to filter an SQL query at runtime:

- [e.QueryName](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.CustomFilterExpressionEventArgs.QueryName) - checks the name of the query that should be filtered. 
- [e.FilterExpression](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.CustomFilterExpressionEventArgs.FilterExpression) - specifies the filter criteria.

This example filters the `Invoices` query with the following expression: "Customers.CompanyName" equals "Around the Horn".

## Files to Review

* [WebForm1.aspx](./CS/ASPxDashboard_CustomFilterExpression/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/ASPxDashboard_CustomFilterExpression/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/ASPxDashboard_CustomFilterExpression/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/ASPxDashboard_CustomFilterExpression/WebForm1.aspx.vb))

## Documentation

- [ASPxDashboard.CustomFilterExpression Event](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomFilterExpression)

## More Examples

- [Dashboard for MVC - How to load different data based on the current user](https://github.com/DevExpress-Examples/DashboardDifferentUserDataMVC)
