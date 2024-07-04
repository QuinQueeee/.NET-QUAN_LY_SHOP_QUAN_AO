using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace frm_DoAn
{
    public partial class frm_NVHD : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_hd = new DataTable();
        string sql = "select * from hoadon";
        bool kt = false;
        private object reportData;
        public frm_NVHD()
        {
            InitializeComponent();
            db.connect();

            dt_hd = db.getDataTable(sql);

            DataColumn[] key = new DataColumn[1];
            key[0] = dt_hd.Columns[0];
            dt_hd.PrimaryKey = key;
        }
        public void loadcb_nv()
        {
            string sql_cbnhanvien = "select * from nhanvien";
            DataTable dt_nhanvien = db.getDataTable(sql_cbnhanvien);
            cbomanv.DataSource = dt_nhanvien;
            cbomanv.DisplayMember = "manv";
            cbomanv.ValueMember = "manv";
        }
        public void loadcb_kh()
        {

            string sql_cbkhachhang = "select * from khachhang";
            DataTable dt_khachhang = db.getDataTable(sql_cbkhachhang);
            cbomakh.DataSource = dt_khachhang;
            cbomakh.DisplayMember = "makh";
            cbomakh.ValueMember = "makh";
        }
        public void loadcb_hh()
        {
            string sql_cbsanpham = "select * from hanghoa";
            DataTable dt_sanpham = db.getDataTable(sql_cbsanpham);
            cbo_masp.DataSource = dt_sanpham;
            cbo_masp.DisplayMember = "masp";
            cbo_masp.ValueMember = "masp";
            kt = true;
        }

        public void load_cthd()
        {
            string sql_load = "select distinct hoadon.mahd,masp,tensp,sluong,dongia,thanhtien,ngaymua,makh,manv from CHITIETHOADON,hoadon where hoadon.MaHD=CHITIETHOADON.mahd ";
            DataTable dt_cthd = db.getDataTable(sql_load);
            dgvhoadon.DataSource = dt_cthd;

        }

        public void load_dongia()
        {
            string sql_dg = "select giaxuat from hanghoa where masp='" + cbo_masp.SelectedValue.ToString() + "'";
            object result = db.getScalar2(sql_dg);

            if (result != null)
            {
                if (float.TryParse(result.ToString(), out float dg))
                {
                    txtdongia.Text = dg.ToString();
                }
                else
                {
                    txtdongia.Text = "INVALID PRICE FORMAT";
                }
            }
            else
            {
                txtdongia.Text = "PRICE NOT FOUND";
            }
        }
        public void load_tensp()
        {
            string sql_tensp = "select tensp from hanghoa where masp='" + cbo_masp.SelectedValue.ToString() + "'";

            object result = db.getScalar2(sql_tensp);

            if (result != null)
            {
                string ten = result.ToString();
                txttensanpham.Text = ten;
            }
            else
            {
                txttensanpham.Text = "PRODUCT NOT FOUND";
            }
        }

        private void frm_NVHD_Load(object sender, EventArgs e)
        {
            load_cthd();
            loadcb_nv();
            loadcb_hh();
            loadcb_kh();
        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtmahd1.Text = dgvhoadon.Rows[numrow].Cells[0].Value.ToString();
            cbo_masp.Text = dgvhoadon.Rows[numrow].Cells[1].Value.ToString();
            txttensanpham.Text = dgvhoadon.Rows[numrow].Cells[2].Value.ToString();
            txtsoluong.Text = dgvhoadon.Rows[numrow].Cells[3].Value.ToString();
            txtdongia.Text = dgvhoadon.Rows[numrow].Cells[4].Value.ToString();
            txtthanhtien.Text = dgvhoadon.Rows[numrow].Cells[5].Value.ToString();
            dtpick.Text = dgvhoadon.Rows[numrow].Cells[6].Value.ToString();
            cbomakh.Text = dgvhoadon.Rows[numrow].Cells[7].Value.ToString();
            cbomanv.Text = dgvhoadon.Rows[numrow].Cells[8].Value.ToString();
        }
        void thanhtien()
        {
            if (int.TryParse(txtsoluong.Text, out int soluong))
            {
                if (float.TryParse(txtdongia.Text, out float dongia))
                {
                    float tt = soluong * dongia;
                    txtthanhtien.Text = tt.ToString();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataRow dr = dt_hd.Rows.Find(txtmahd1.Text);
            if (dr != null)
            {
                dr["ngaymua"] = dtpick.Text;
                dr["makh"] = cbomakh.Text;
                dr["manv"] = cbomanv.Text;

            }
            int kq = db.updateDatabase(sql, dt_hd);
            if (kq > 0)
                MessageBox.Show("SỬA THÀNH CÔNG");
            else
                MessageBox.Show("SỬA KHÔNG THÀNH CÔNG");


            string sql_chinhsua = "select * from chitiethoadon";
            DataTable dt_chinhsua = db.getDataTable(sql_chinhsua);
            DataColumn[] key2 = new DataColumn[1];
            key2[0] = dt_chinhsua.Columns[0];
            dt_chinhsua.PrimaryKey = key2;
            DataRow dr2 = dt_chinhsua.Rows.Find(txtmahd1.Text);
            if (dr2 != null)
            {
                dr2["masp"] = cbo_masp.Text;
                dr2["tensp"] = txttensanpham.Text;
                dr2["sluong"] = txtsoluong.Text;
                dr2["dongia"] = txtdongia.Text;
                dr2["thanhtien"] = txtthanhtien.Text;
            }
            db.updateDatabase(sql_chinhsua, dt_chinhsua);
            load_cthd();
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            thanhtien();
        }

        private void cbo_masp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kt)
            {
                load_tensp();
                load_dongia();
                thanhtien();
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private DataTable InHD(string mahd, string manv, string makh, string tensp, int sluong, float dongia, float thanhtien)
        {
            DataTable resultTable = new DataTable();
            try
            {
                using (SqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string queryString = "select hoadon.mahd, hoadon.manv, hoadon.makh, chitiethoadon.tensp, chitiethoadon.sluong, chitiethoadon.dongia, chitiethoadon.thanhtien from hoadon inner join chitiethoadon on chitiethoadon.mahd = hoadon.mahd where hoadon.mahd = @MaHD";

                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@MaHD", mahd);
                        command.Parameters.AddWithValue("@MaNV", manv);
                        command.Parameters.AddWithValue("@MaKH", makh);
                        command.Parameters.AddWithValue("@TenSP", tensp);
                        command.Parameters.AddWithValue("@SLuong", sluong);
                        command.Parameters.AddWithValue("@DonGia", dongia);
                        command.Parameters.AddWithValue("@ThanhTien", thanhtien);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(resultTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI KHI IN HÓA ĐƠN: " + ex.Message);
            }

            return resultTable;
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd1.Text;
            string manv = cbomanv.Text;
            string makh = cbomakh.Text;
            string tensp = txttensanpham.Text;
            int sluong = int.Parse(txtsoluong.Text);
            float dongia = float.Parse(txtdongia.Text);
            float thanhtien = float.Parse(txtthanhtien.Text);
            DataTable resultTable = InHD(mahd, manv, makh, tensp, sluong, dongia, thanhtien);
            frm_HDBH Report = new frm_HDBH(resultTable);

            //this.Hide(); // Ẩn formThongKe
            Report.Closed += (s, args) => this.Show(); // Đăng ký sự kiện Closed của formReport
            Report.Show();
        }
    }
}
