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
    public partial class frm_QLKH : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_KH = new DataTable();
       public frm_QLKH()
        {
            InitializeComponent();
            db.connect();
            string sql = "select * from KHACHHANG";
            dt_KH = db.getDataTable(sql);

            DataColumn[] key = new DataColumn[1];
            key[0] = dt_KH.Columns[0];
            dt_KH.PrimaryKey = key;
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_MaKH.Clear();
            txt_Name.Clear();
            txt_SDT.Clear();
            txt_Address.Clear();
            rdo_Nam.Checked = false;
            rdo_Nu.Checked = false;
            date_NgSinh.ResetText();
            txt_Email.Clear();
            txt_MaKH.Focus();
        }

        public void load_dgvListKH()
        {
            dgv_ListKH.DataSource = dt_KH;
        }
        private void frm_ListKH_Load(object sender, EventArgs e)
        {
            load_dgvListKH();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string makh = txt_MaKH.Text;
            using (SqlConnection conn = db.getConnection())
            {
                conn.Open();
                string query = "select count(*) from khachhang where makh = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", makh);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("MÃ KHÁCH HÀNG ĐÃ TỒN TẠI!!!");
                    return;
                }
                else
                {
                    DataRow dr = dt_KH.NewRow();
                    dr["MaKH"] = txt_MaKH.Text;
                    dr["TenKH"] = txt_Name.Text;
                    dr["SDT"] = txt_SDT.Text;
                    dr["DiaChi"] = txt_Address.Text;
                    if (rdo_Nam.Checked == true)
                        dr["GTinh"] = rdo_Nam.Text;
                    else
                        dr["GTinh"] = rdo_Nu.Text;
                    dr["NGSinh"] = date_NgSinh.Text;
                    dr["Email"] = txt_Email.Text;
                    dt_KH.Rows.Add(dr);
                    string sql = "select * from KHACHHANG";
                    int kq = db.updateDatabase(sql, dt_KH);
                    if (kq > 0)
                        MessageBox.Show("THÊM THÔNG TIN KHÁCH HÀNG THÀNH CÔNG!!!");
                    else
                        MessageBox.Show("LỖI KHI THÊM THÔNG TIN KHÁCH HÀNG!!!");
                    load_dgvListKH();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int row = dgv_ListKH.SelectedCells[0].RowIndex;
                string makh = dgv_ListKH.Rows[row].Cells[0].Value.ToString();
                using (SqlConnection conn = db.getConnection())
                {
                    conn.Open();
                    string query = "select count(*) from hoadon where makh = @MaKH";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaKH", makh);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("MÃ KHÁCH HÀNG ĐANG TỒN TẠI TRONG BẢNG HÓA ĐƠN!!!");
                        return;
                    }
                    else
                    {
                        DataRow dr = dt_KH.Rows.Find(txt_MaKH.Text);
                        if (dr != null)
                            dr.Delete();
                        string sql = "select * from KHACHHANG";
                        int kq = db.updateDatabase(sql, dt_KH);
                        if (kq > 0)
                            MessageBox.Show("XÓA THÔNG TIN KHÁCH HÀNG THÀNH CÔNG!!!");
                        else
                            MessageBox.Show("LỖI KHI XÓA THÔNG TIN KHÁCH HÀNG!!!");
                        load_dgvListKH();
                    }
                }
            }
            else
                MessageBox.Show("ĐÃ HỦY YÊU CẦU XÓA!!!");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_KH.Rows.Find(txt_MaKH.Text);
            if (dr != null)
            {
                dr["TenKH"] = txt_Name.Text;
                dr["SDT"] = txt_SDT.Text;
                dr["DiaChi"] = txt_Address.Text;
                if (rdo_Nam.Checked == true)
                    dr["GTinh"] = rdo_Nam.Text;
                else
                    dr["GTinh"] = rdo_Nu.Text;
                dr["NGSinh"] = date_NgSinh.Text;
                dr["Email"] = txt_Email.Text;
            }
            string sql = "select * from KHACHHANG";
            int kq = db.updateDatabase(sql, dt_KH);
            if (kq > 0)
                MessageBox.Show("SỬA THÔNG TIN KHÁCH HÀNG THÀNH CÔNG!!!");
            else
                MessageBox.Show("LỖI KHI SỬA THÔNG TIN KHÁCH HÀNG!!!");
            load_dgvListKH();
        }

        private void dgv_ListKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_MaKH.Text = dgv_ListKH.Rows[numrow].Cells[0].Value.ToString();
            txt_Name.Text = dgv_ListKH.Rows[numrow].Cells[1].Value.ToString();
            txt_SDT.Text = dgv_ListKH.Rows[numrow].Cells[2].Value.ToString();
            txt_Address.Text = dgv_ListKH.Rows[numrow].Cells[3].Value.ToString();
            string gt = dgv_ListKH.Rows[numrow].Cells[4].Value.ToString();
            if (gt == "Nam")
                rdo_Nam.Checked = true;
            else
                rdo_Nu.Checked = true;
            date_NgSinh.Text = dgv_ListKH.Rows[numrow].Cells[5].Value.ToString();
            txt_Email.Text = dgv_ListKH.Rows[numrow].Cells[6].Value.ToString();
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
