using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace frm_DoAn
{
    public partial class frm_HDBH : Form
    {
        private DataTable reportData;

        public frm_HDBH()
        {
        }

        public frm_HDBH(DataTable data)
        {
            InitializeComponent();
            reportData = data;
        }

        public ReportDocument Report { get; set; }

        private void frm_HDBH_Load(object sender, EventArgs e)
        {
            CrystalReport3 rpt = new CrystalReport3();
            crystalReportViewer2.ReportSource = rpt;
            rpt.Load(@"C:\Đồ án .NET\frm_DoAn\frm_DoAn\CrystalReport3.rpt");
            rpt.SetDataSource(reportData);
            rpt.SetDatabaseLogon("sa", "123");
            crystalReportViewer2.Refresh();
            crystalReportViewer2.DisplayToolbar = false;
            crystalReportViewer2.DisplayStatusBar = false;
        }
    }
}
