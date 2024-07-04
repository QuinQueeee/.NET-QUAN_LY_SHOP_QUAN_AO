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
    public partial class frm_MainNV : Form
    {
        public frm_MainNV()
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
            OpenChildForm(new frm_NVHD());
        }

        private void btn_TC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NVTC());
        }

        private void btn_KH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QLKH());
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MainNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THOÁT?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == kq)
                e.Cancel = true;
            frm_Login login = new frm_Login();
            login.Show();
        }
    }
}
