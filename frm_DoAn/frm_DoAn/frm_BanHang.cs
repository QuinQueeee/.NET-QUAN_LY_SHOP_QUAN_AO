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
    public partial class frm_BanHang : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_hd = new DataTable();
        string sql = "select * from hoadon";
        DataTable dt_cthd = new DataTable();
        string sql1 = "select * from chitiethoadon";
        bool kt = false;

        public frm_BanHang()
        {
            InitializeComponent();
            db.connect();
            dt_hd = db.getDataTable(sql);
            DataColumn[] key = new DataColumn[1];
            key[0] = dt_hd.Columns[0];
            dt_hd.PrimaryKey = key;

            dt_cthd = db.getDataTable(sql1);
            DataColumn[] key1 = new DataColumn[2];
            key1[0] = dt_cthd.Columns[0];
            key1[1] = dt_cthd.Columns[1];
            dt_cthd.PrimaryKey = key1;
        }
        public void loadcb_nv()
        {
            string sql_cbnhanvien = "select * from nhanvien";
            DataTable dt_nhanvien = db.getDataTable(sql_cbnhanvien);
            cbo_NV.DataSource = dt_nhanvien;
            cbo_NV.DisplayMember = "tennv";
            cbo_NV.ValueMember = "manv";
        }
        public void loadcb_kh()
        {

            string sql_cbkhachhang = "select * from khachhang";
            DataTable dt_khachhang = db.getDataTable(sql_cbkhachhang);
            cbo_KH.DataSource = dt_khachhang;
            cbo_KH.DisplayMember = "tenkh";
            cbo_KH.ValueMember = "makh";
        }
        public void loadcb_hh()
        {
            string sql_cbsanpham = "select * from hanghoa";
            DataTable dt_sanpham = db.getDataTable(sql_cbsanpham);
            cbo_MaSP.DataSource = dt_sanpham;
            cbo_MaSP.DisplayMember = "masp";
            cbo_MaSP.ValueMember = "masp";
            kt = true;
        }
        public void load_dongia()
        {
            string sql_dg = "select giaxuat from hanghoa where masp='" + cbo_MaSP.SelectedValue.ToString() + "'";
            object result = db.getScalar2(sql_dg);

            if (result != null)
            {
                if (float.TryParse(result.ToString(), out float dg))
                {
                    txt_DonGia.Text = dg.ToString();
                }
                else
                {
                    txt_DonGia.Text = "INVALID FORMAT PRICE";
                }
            }
            else
            {
                txt_DonGia.Text = "PRICE NOT FOUND";
            }
        }
        public void load_tensp()
        {
            string sql_tensp = "select tensp from hanghoa where masp='" + cbo_MaSP.SelectedValue.ToString() + "'";

            object result = db.getScalar2(sql_tensp);

            if (result != null)
            {
                string ten = result.ToString();
                txt_SP.Text = ten;
            }
            else
            {
                txt_SP.Text = "PRODUCT NOT FOUND";
            }
        }
        void thanhtien()
        {
            if (int.TryParse(txt_SoLuong.Text, out int soluong))
            {
                if (float.TryParse(txt_DonGia.Text, out float dongia))
                {
                    float tt = soluong * dongia;
                    txtThanhTien.Text = tt.ToString();
                }
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DataRow existing = dt_hd.Rows.Find(txtmahd.Text);
            if (existing != null)
            {
                DataRow dr1 = dt_cthd.NewRow();
                dr1["mahd"] = txtmahd.Text;
                dr1["masp"] = cbo_MaSP.SelectedValue.ToString();
                dr1["tensp"] = txt_SP.Text;
                dr1["sluong"] = txt_SoLuong.Text;
                dr1["dongia"] = txt_DonGia.Text;
                dr1["thanhtien"] = txtThanhTien.Text;
                dt_cthd.Rows.Add(dr1);
                int kq1 = db.updateDatabase(sql1, dt_cthd);
                if (kq1 > 0)
                {
                    MessageBox.Show("THÊM CHI TIẾT HÓA ĐƠN THÀNH CÔNG!!!");
                }
                else
                {
                    MessageBox.Show("THÊM KHÔNG THÀNH CÔNG!!!");
                }
            }
            else
            {
                DataRow dr = dt_hd.NewRow();
                dr["mahd"] = txtmahd.Text;
                dr["makh"] = cbo_KH.SelectedValue.ToString();
                dr["manv"] = cbo_NV.SelectedValue.ToString();
                dr["ngaymua"] = dtpNgayMua.Text;
                dt_hd.Rows.Add(dr);
                int kq = db.updateDatabase(sql, dt_hd);

                DataRow dr1 = dt_cthd.NewRow();
                dr1["mahd"] = txtmahd.Text;
                dr1["masp"] = cbo_MaSP.SelectedValue.ToString();
                dr1["tensp"] = txt_SP.Text;
                dr1["sluong"] = txt_SoLuong.Text;
                dr1["dongia"] = txt_DonGia.Text;
                dr1["thanhtien"] = txtThanhTien.Text;
                dt_cthd.Rows.Add(dr1);
                int kq1 = db.updateDatabase(sql1, dt_cthd);
                if (kq > 0 && kq1 > 0)
                {
                    MessageBox.Show("THANH TOÁN THÀNH CÔNG!!!");
                    //lblTongTien.Text = "TỔNG HÓA ĐƠN: ";
                }
                else
                    MessageBox.Show("THANH TOÁN THẤT BẠI!!!");
            }
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            loadcb_hh();
            loadcb_kh();
            loadcb_nv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            string kh = cbo_KH.SelectedValue.ToString();
            string nv = cbo_NV.SelectedValue.ToString();
            string ngaymua = dtpNgayMua.Value.ToString();
            string masp = cbo_MaSP.SelectedValue.ToString();
            string sp = txt_SP.Text;
            int soluong = int.Parse(txt_SoLuong.Text);
            float dongia = float.Parse(txt_DonGia.Text);
            float thanhtien = float.Parse(txtThanhTien.Text);

            dgv_HD.Rows.Add(mahd, kh, nv, ngaymua, masp, sp, soluong, dongia, thanhtien);
            TotalBill();
        }
        private void TotalBill()
        {
            decimal total = 0;
            if (dgv_HD != null)
            {
                foreach (DataGridViewRow row in dgv_HD.Rows)
                {
                    if (row.Cells[8] != null && row.Cells[8].Value != null)
                    {
                        if (decimal.TryParse(row.Cells[8].Value.ToString(), out decimal value))
                        {
                            total += value;
                        }
                        else
                        {
                            total = 0;
                        }
                    }
                }
            }
            lblTongTien.Text = "TỔNG HÓA ĐƠN: " + total.ToString("N0") + " VNĐ";
        }

        private void cbo_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kt)
            {
                load_tensp();
                load_dongia();
                thanhtien();
            }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            thanhtien();
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            dgv_HD.Rows.Clear();
            dgv_HD.Refresh();
            dtpNgayMua.ResetText();
            txt_SP.Text = " ";
            txt_SoLuong.Clear();
            txt_DonGia.Text = " ";
            txtThanhTien.Clear();
            cbo_KH.SelectedIndex = 0;
            cbo_NV.SelectedIndex = 0;
            cbo_MaSP.SelectedIndex = 0;
            lblTongTien.Text = "TỔNG HÓA ĐƠN: ";
            string sql = "select count(mahd) from hoadon";
            int stt = (int)db.getScalar(sql);
            stt++;
            string strstt = stt.ToString("000");
            string maHD = "HD" + strstt;
            txtmahd.Text = maHD;
        }
    }
}
