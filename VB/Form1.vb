Imports System
Imports System.IO
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports StoreRepInDB.ReportsDBDataSetTableAdapters

' ...
Namespace StoreRepInDB

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private dataAdapter1 As ReportsTableAdapter = New ReportsTableAdapter()

        Private dataSet1 As ReportsDBDataSet = New ReportsDBDataSet()

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a new report.
            Dim report As XtraReport1 = New XtraReport1()
            ' Save the report to a stream.
            Dim stream As MemoryStream = New MemoryStream()
            report.SaveLayout(stream)
            ' Prepare the stream for reading.
            stream.Position = 0
            ' Insert the report to a database.
            Using sr As StreamReader = New StreamReader(stream)
                ' Read the report from the stream to a string variable.
                Dim s As String = sr.ReadToEnd()
                ' Add a row to a table.
                Dim dt As DataTable = dataSet1.Tables("Reports")
                Dim row As DataRow = dt.NewRow()
                row("Report") = s
                dt.Rows.Add(row)
            End Using

            ' Commit changes.
            dataAdapter1.Update(dataSet1)
            dataSet1.AcceptChanges()
        End Sub

        Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Declare a base report variable.
            Dim newReport As XtraReport
            ' Retrieve a string which contains the report.
            Dim s As String = dataSet1.Tables(CStr("Reports")).Rows(0)("Report").ToString()
            ' Obtain the report from the string.
            Using sw As StreamWriter = New StreamWriter(New MemoryStream())
                sw.Write(s)
                sw.Flush()
                newReport = XtraReport.FromStream(sw.BaseStream, True)
            End Using

            ' Preview the report.
            newReport.ShowPreview()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Fill the datasource.
            dataAdapter1.Fill(dataSet1.Reports)
        End Sub
    End Class
End Namespace
