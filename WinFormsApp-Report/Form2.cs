using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_Report.Models;

namespace WinFormsApp_Report
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (var context = new loginContext())
            {
                // Fetch data using EF Core
                var userList = context.Users.ToList();

                // Convert data to DataTable for ReportViewer
                DataTable dt = new DataTable();
                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("type", typeof(string));
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("age", typeof(int));

                foreach (var user in userList)
                {
                    dt.Rows.Add(user.Id, user.Type, user.Name, user.Age);
                }

                // Bind DataTable to ReportViewer
                reportViewer1.LocalReport.ReportPath = @"C:\Users\abdellateef_eid\source\repos\WinFormsApp-Report\WinFormsApp-Report\Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                // Refresh the report
                reportViewer1.RefreshReport();
            }
        }
    }
}
