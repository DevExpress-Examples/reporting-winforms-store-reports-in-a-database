# Reporting for WinForms - How to Store Reports in a Database


This example shows how to save (load) a report definition to (from) a database. The application saves reports using the [XtraReport.SaveLayout](http://docs.devexpress.devx/XtraReports/DevExpress.XtraReports.UI.XtraReport.SaveLayout.overloads) method to the `ReportsDB.mdb` Microsoft Access database. The [XtraReport.LoadLayout](http://docs.devexpress.devx/XtraReports/DevExpress.XtraReports.UI.XtraReport.LoadLayout(System.IO.Stream)) method loads a report from the database.

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
## Documentation

* [Custom Report Storage](http://docs.devexpress.devx/XtraReports/10001/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/store-report-layouts-and-documents/custom-report-storage)

## More Examples

- [Reporting for WPF - How to Implement a Report Storage](https://github.com/DevExpress-Examples/Reporting_wpf-end-user-report-designer-how-to-implement-a-report-storage-t292945)
- [Reporting for Web Forms - Report Designer with Report Storage and Custom Command](https://github.com/DevExpress-Examples/reporting-web-forms-designer-storage)
- [Reporting for ASP.NET MVC - Report Designer with Report Database Storage](https://github.com/DevExpress-Examples/reporting-web-mvc-db-storage)
- [How to Implement a Custom Report Storage](https://github.com/DevExpress-Examples/reporting-winforms-custom-report-storage) 
