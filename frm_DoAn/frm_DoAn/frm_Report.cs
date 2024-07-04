using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_DoAn
{
    public partial class frm_Report : Form
    {
        private DataTable reportData;
        public frm_Report(DataTable data)
        {
            InitializeComponent();
            reportData = data;
        }

        private void frm_Report_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            crystalReportViewer1.ReportSource = rpt;
            rpt.Load(@"C:\Đồ án .NET\frm_DoAn\frm_DoAn\CrystalReport1.rpt");
            rpt.SetDataSource(reportData);
            rpt.SetDatabaseLogon("sa", "123");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
