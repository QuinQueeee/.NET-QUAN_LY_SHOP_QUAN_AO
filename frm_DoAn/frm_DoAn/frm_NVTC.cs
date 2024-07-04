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
    public partial class frm_NVTC : Form
    {
        public frm_NVTC()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            currentFormChild.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_TCHH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TCHH());
        }

        private void btn_TCKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TCKH());
        }

        private void btn_TCHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TCHD());
        }
    }
}
