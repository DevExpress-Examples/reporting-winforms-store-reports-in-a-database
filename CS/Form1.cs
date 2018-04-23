using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using StoreRepInDB.ReportsDBDataSetTableAdapters;
// ...

namespace StoreRepInDB {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        ReportsTableAdapter dataAdapter1 = new ReportsTableAdapter();
        ReportsDBDataSet dataSet1 = new ReportsDBDataSet();

        private void btnSave_Click(object sender, EventArgs e) {
            // Create a new report.
            XtraReport1 report = new XtraReport1();

            // Save the report to a stream.
            MemoryStream stream = new MemoryStream();
            report.SaveLayout(stream);

            // Prepare the stream for reading.
            stream.Position = 0;

            // Insert the report to a database.
            using(StreamReader sr = new StreamReader(stream)) {
                // Read the report from the stream to a string variable.
                string s = sr.ReadToEnd();

                // Add a row to a table.
                DataTable dt = dataSet1.Tables["Reports"];
                DataRow row = dt.NewRow();
                row["Report"] = s;
                dt.Rows.Add(row);
            }

            // Commit changes.
            dataAdapter1.Update(dataSet1);
            dataSet1.AcceptChanges();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            // Declare a base report variable.
            XtraReport newReport;

            // Retrieve a string which contains the report.
            string s = dataSet1.Tables["Reports"].Rows[0]["Report"].ToString();

            // Obtain the report from the string.
            using(StreamWriter sw = new StreamWriter(new MemoryStream())) {
                sw.Write(s);
                sw.Flush();
                newReport = XtraReport.FromStream(sw.BaseStream, true);
            }

            // Preview the report.
            newReport.ShowPreview();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Fill the datasource.
            dataAdapter1.Fill(dataSet1.Reports);
        }

    }
}