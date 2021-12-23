using System;
using DevExpress.DashboardWeb;
using DevExpress.Data.Filtering;

namespace ASPxDashboard_CustomFilterExpression {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxDashboard1.SetDashboardStorage(new DashboardFileStorage("~/App_Data/Dashboards"));
        }

        protected void ASPxDashboard1_CustomFilterExpression(object sender, CustomFilterExpressionWebEventArgs e) {
            if (e.DashboardId == "dashboard1" && e.TableName == "Invoices") {
                e.FilterExpression = new BinaryOperator("CustomerID", "AROUT", BinaryOperatorType.Equal);
            }
        }
    }
}