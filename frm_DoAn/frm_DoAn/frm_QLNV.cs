using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_DoAn
{
    public partial class frm_QLNV : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_nv = new DataTable();
        public frm_QLNV()
        {
            InitializeComponent();
            db.connect();
            string sql = "select * from NHANVIEN";
            dt_nv = db.getDataTable(sql);

            DataColumn[] key = new DataColumn[1];
            key[0] = dt_nv.Columns[0];
            dt_nv.PrimaryKey = key;
        }
        public void load_nv()
        {
            string sql_load = "select * from NHANVIEN";
            DataTable dt_nv = db.getDataTable(sql_load);
            dataGridView1.DataSource = dt_nv;
            databingding(dt_nv);
        }
        void databingding(DataTable pDT)
        {
            txtmanv.DataBindings.Clear();
            txttennhanvien.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            rdogtnam.DataBindings.Clear();
            rdogtnu.DataBindings.Clear();
            dtpick.DataBindings.Clear();
            txtdangnhap.DataBindings.Clear();
            txtmatkhau.DataBindings.Clear();
            txtemail.DataBindings.Clear();
            txtmanv.DataBindings.Add("Text", pDT, "manv");
            txttennhanvien.DataBindings.Add("Text", pDT, "tennv");
            txtsdt.DataBindings.Add("Text", pDT, "sdt");
            txtdiachi.DataBindings.Add("Text", pDT, "diachi");
            dtpick.DataBindings.Add("Text", pDT, "ngsinh");
            txtemail.DataBindings.Add("Text", pDT, "email");
            txtdangnhap.DataBindings.Add("Text", pDT, "tendangnhap");
            txtmatkhau.DataBindings.Add("Text", pDT, "password");

        }

        private void frm_QLNV_Load(object sender, EventArgs e)
        {
            load_nv();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            using (SqlConnection conn = db.getConnection())
            {
                conn.Open();
                string query = "select count(*) from nhanvien where manv = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", manv);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("MÃ NHÂN VIÊN ĐÃ TỒN TẠI!!!");
                    return;
                }
                else
                {
                    DataRow row = dt_nv.NewRow();
                    row["MaNV"] = txtmanv.Text;
                    row["TenNV"] = txttennhanvien.Text;
                    row["SDT"] = txtsdt.Text;
                    row["DiaChi"] = txtdiachi.Text;
                    if (rdogtnam.Checked == true)
                    {
                        row["GTinh"] = rdogtnam.Text;
                    }
                    else
                        row["GTinh"] = rdogtnu.Text;
                    //row["ngsinh"] = txtngaysinh.Text;
                    row["NGSinh"] = dtpick.Text;
                    row["TenDangNhap"] = txtdangnhap.Text;
                    row["Password"] = txtmatkhau.Text;
                    row["Email"] = txtemail.Text;
                    if (rdoQLi.Checked == true)
                    {
                        row["RoleID"] = 1;
                    }
                    else
                        row["RoleID"] = 2;
                    dt_nv.Rows.Add(row);
                    string sql = "select * from NHANVIEN";
                    int kq = db.updateDatabase(sql, dt_nv);
                    if (kq > 0)
                        MessageBox.Show("THÊM THÔNG TIN NHÂN VIÊN THÀNH CÔNG");
                    else
                        MessageBox.Show("THÊM KHÔNG THÀNH CÔNG");
                    load_nv();
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int row = dataGridView1.SelectedCells[0].RowIndex;
                string manv = dataGridView1.Rows[row].Cells[0].Value.ToString();
                using (SqlConnection conn = db.getConnection())
                {
                    conn.Open();
                    string query = "select count(*) from hoadon where manv = @MaNV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", manv);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("MÃ NHÂN VIÊN ĐANG TỒN TẠI TRONG BẢNG HÓA ĐƠN!!!");
                        return;
                    }
                    else
                    {
                        DataRow dr = dt_nv.Rows.Find(txtmanv.Text);
                        if (dr != null)
                        {
                            dr.Delete();
                        }
                        string sql = "select * from NHANVIEN";
                        int kq = db.updateDatabase(sql, dt_nv);
                        if (kq > 0)
                            MessageBox.Show("XÓA THÔNG TIN NHÂN VIÊN THÀNH CÔNG");
                        else
                            MessageBox.Show("XÓA KHÔNG THÀNH CÔNG");
                        load_nv();
                    }
                }
            }
            else
                MessageBox.Show("ĐÃ HỦY YÊU CẦU XÓA!!!");
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_nv.Rows.Find(txtmanv.Text);
            if (dr != null)
            {
                dr["tennv"] = txttennhanvien.Text;
                dr["sdt"] = txtsdt.Text;
                dr["diachi"] = txtdiachi.Text;
                if (rdogtnam.Checked)
                {
                    dr["gtinh"] = rdogtnam.Text;
                }
                else
                {
                    dr["gtinh"] = rdogtnu.Text;
                }
                //dr["ngsinh"] = txtngaysinh.Text;
                dr["ngsinh"] = dtpick.Text;
                dr["tendangnhap"] = txtdangnhap.Text;
                dr["password"] = txtmatkhau.Text;
                if (rdoQLi.Checked == true)
                {
                    dr["RoleID"] = 1;
                }
                else
                    dr["RoleID"] = 2;
            }
            string sql = "select * from NHANVIEN";
            int kq = db.updateDatabase(sql, dt_nv);
            if (kq > 0)
                MessageBox.Show("SỬA THÔNG TIN NHÂN VIÊN THÀNH CÔNG");
            else
                MessageBox.Show("SỬA KHÔNG THÀNH CÔNG");
            load_nv();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txtdangnhap.Clear();
            txtdiachi.Clear();
            txtemail.Clear();
            txtmatkhau.Clear();
            txtsdt.Clear();
            txttennhanvien.Clear();
            rdogtnam.Checked = false;
            rdogtnu.Checked = false;
            dtpick.ResetText();
            rdoQLi.Checked = false;
            rdoNVien.Checked = false;
            txtmanv.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            string gt = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            if (gt == "Nam")
                rdogtnam.Checked = true;
            else
                rdogtnu.Checked = true;
            string quyen = dataGridView1.Rows[numrow].Cells[9].Value.ToString();
            if (quyen == "1")
                rdoQLi.Checked = true;
            else
                rdoNVien.Checked = true;
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
