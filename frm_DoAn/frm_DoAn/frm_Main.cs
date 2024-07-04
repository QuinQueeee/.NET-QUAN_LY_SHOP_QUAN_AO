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
    public partial class frm_Main : Form
    {
        public frm_Main()
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

        private void btn_BH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_BanHang());
        }

        private void btn_HD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_HoaDon());
        }

        private void btn_TC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TC());
        }

        private void btn_QL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QL());
        }

        private void btn_TKDT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TKDT());
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq;
            kq=MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THOÁT?","XÁC NHẬN",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.No == kq)
                e.Cancel = true;
            frm_Login login = new frm_Login();
            login.Show();
        }
    }
}
