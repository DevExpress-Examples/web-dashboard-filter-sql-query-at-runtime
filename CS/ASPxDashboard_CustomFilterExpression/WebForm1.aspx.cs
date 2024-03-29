﻿using System;
using DevExpress.DashboardWeb;
using DevExpress.Data.Filtering;

namespace ASPxDashboard_CustomFilterExpression {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxDashboard1.SetDashboardStorage(new DashboardFileStorage("~/App_Data/Dashboards"));
        }

        protected void ASPxDashboard1_CustomFilterExpression(object sender, CustomFilterExpressionWebEventArgs e) {
            if (e.DataSourceConnectionName == "nwindConnection" && e.QueryName == "Invoices") {
                e.FilterExpression = new BinaryOperator("Customers.CompanyName", "Around the Horn", BinaryOperatorType.Equal);
            }
        }
    }
}