using Microsoft.Reporting.WinForms;
using System.Data;
using WinFormsApp_Report.Models;

namespace WinFormsApp_Report
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (var context = new loginContext())
            {
                // Fetch data using EF Core
                var studentsList = context.Students.ToList();

                // Convert data to DataTable for ReportViewer
                DataTable dt = new DataTable();
                dt.Columns.Add("st_id", typeof(int));
                dt.Columns.Add("st_name", typeof(string));

                foreach (var st in studentsList)
                {
                    dt.Rows.Add(st.StId, st.StName);
                }

                // Bind DataTable to ReportViewer
                reportViewer1.LocalReport.ReportPath = @"C:\Users\abdellateef_eid\source\repos\WinFormsApp-Report\WinFormsApp-Report\Report2.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                // Refresh the report
                reportViewer1.RefreshReport();
            }
        }
    }
}
