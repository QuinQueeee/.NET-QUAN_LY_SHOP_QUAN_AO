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
    public partial class frm_QLHH : Form
    {
        private string connectionString = @"Data Source = QUINQUE\QUIN; Initial Catalog = QL_SHOPTHOITRANG; User ID = sa; Password = 123";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public frm_QLHH()
        {
            InitializeComponent();
        }

        private void frm_QLHH_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                string query = "SELECT * FROM HANGHOA";
                adapter = new SqlDataAdapter(query, connection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                string tenSP = selectedRow.Cells["TenSP"].Value.ToString();
                string giaNhap = selectedRow.Cells["GiaNhap"].Value.ToString();
                string giaXuat = selectedRow.Cells["GiaXuat"].Value.ToString();
                string kieuDang = selectedRow.Cells["KieuDang"].Value.ToString();
                string tinhTrang = selectedRow.Cells["TinhTrang"].Value.ToString();
                string ngayNhap = selectedRow.Cells["NgayNhap"].Value.ToString();
                string soLuong = selectedRow.Cells["SoLuong"].Value.ToString();
                string daBan = selectedRow.Cells["DaBan"].Value.ToString();
                string chatLieu = selectedRow.Cells["ChatLieu"].Value.ToString();

                txtMaSP.Text = maSP;
                txtTenSP.Text = tenSP;
                txtGianhap.Text = giaNhap;
                txtGiaXuat.Text = giaXuat;
                dtpNgayNhap.Value = DateTime.Parse(ngayNhap);
                txtSoluong.Text = soLuong;
                txtDaban.Text = daBan;
                txtChatLieu.Text = chatLieu;

                rdoNam.Checked = kieuDang == "Nam";
                rdoNu.Checked = kieuDang == "Nữ";
                rdoCon.Checked = tinhTrang == "Còn Hàng";
                rdoHet.Checked = tinhTrang == "Hết Hàng";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            string giaNhap = txtGianhap.Text;
            string giaXuat = txtGiaXuat.Text;
            string kieuDang = rdoNam.Checked ? "Nam" : "Nữ";
            string tinhTrang = rdoCon.Checked ? "Còn Hàng" : "Hết Hàng";

            DateTime ngayNhap = dtpNgayNhap.Value;
            string ngayNhapFormatted = ngayNhap.ToString("yyyy-MM-dd");

            string soLuong = txtSoluong.Text;
            string daBan = txtDaban.Text;
            string chatLieu = txtChatLieu.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql1 = "select count(*) from hanghoa where masp = @MaSP";
                    SqlCommand cmd1 = new SqlCommand(sql1, connection);
                    cmd1.Parameters.AddWithValue("@MaSP", maSP);
                    int count = (int)cmd1.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("MÃ SẢN PHẨM ĐÃ TỒN TẠI!!!");
                        return;
                    }
                    else
                    {
                        string query = "INSERT INTO HANGHOA (MaSP, TenSP, GiaNhap, GiaXuat, KieuDang, TinhTrang, NgayNhap, SoLuong, DaBan, ChatLieu) " +
                        "VALUES (@MaSP, @TenSP, @GiaNhap, @GiaXuat, @KieuDang, @TinhTrang, @NgayNhap, @SoLuong, @DaBan, @ChatLieu)";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.Parameters.AddWithValue("@TenSP", tenSP);
                        cmd.Parameters.AddWithValue("@GiaNhap", giaNhap);
                        cmd.Parameters.AddWithValue("@GiaXuat", giaXuat);
                        cmd.Parameters.AddWithValue("@KieuDang", kieuDang);
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                        cmd.Parameters.AddWithValue("@NgayNhap", ngayNhapFormatted);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@DaBan", daBan);
                        cmd.Parameters.AddWithValue("@ChatLieu", chatLieu);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("SẢN PHẨM ĐƯỢC THÊM THÀNH CÔNG");
                            UpdateDataGridView();
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show("LỖI KHI THÊM SẢN PHẨM!!!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI KHI THÊM SẢN PHẨM: " + ex.Message);
            }
        }

        private void UpdateDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM HANGHOA";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI CẬP NHẬT DATAGRIDVIEW: " + ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearData();
            txtMaSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    string maSP = dataGridView1.Rows[rowIndex].Cells["MaSP"].Value.ToString();

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query1 = "select count(*) from chitiethoadon where masp = @MaSP";
                            SqlCommand cmd1 = new SqlCommand(query1, connection);
                            cmd1.Parameters.AddWithValue("@MaSP", maSP);
                            int count = (int)cmd1.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("MÃ SẢN PHẨM ĐANG TỒN TẠI TRONG BẢNG CHI TIẾT HÓA ĐƠN!!!");
                                return;
                            }
                            else
                            {
                                string query = "DELETE FROM HANGHOA WHERE MaSP = @MaSP";
                                SqlCommand cmd = new SqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@MaSP", maSP);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("SẢN PHẨM ĐƯỢC XÓA THÀNH CÔNG");
                                    UpdateDataGridView();
                                    ClearData();
                                }
                                else
                                {
                                    MessageBox.Show("KHÔNG TÌM THẤY SẢN PHẨM ĐỂ XÓA");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("LỖI KHI XÓA SẢN PHẨM: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("VUI LÒNG CHỌN MỘT SẢN PHẨM ĐỂ XÓA");
                }
            }
            else
                MessageBox.Show("ĐÃ HỦY YÊU CẦU XÓA!!!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                string maSP = dataGridView1.Rows[rowIndex].Cells["MaSP"].Value.ToString();

                string tenSP = txtTenSP.Text;
                string giaNhap = txtGianhap.Text;
                string giaXuat = txtGiaXuat.Text;
                string kieuDang = rdoNam.Checked ? "Nam" : "Nữ";
                string tinhTrang = rdoCon.Checked ? "Còn Hàng" : "Hết Hàng";

                DateTime ngayNhap = dtpNgayNhap.Value;
                string ngayNhapFormatted = ngayNhap.ToString("yyyy-MM-dd");

                string soLuong = txtSoluong.Text;
                string daBan = txtDaban.Text;
                string chatLieu = txtChatLieu.Text;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE HANGHOA SET TenSP = @TenSP, GiaNhap = @GiaNhap, GiaXuat = @GiaXuat, KieuDang = @KieuDang, TinhTrang = @TinhTrang, NgayNhap = @NgayNhap, SoLuong = @SoLuong, DaBan = @DaBan, ChatLieu = @ChatLieu WHERE MaSP = @MaSP";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.Parameters.AddWithValue("@TenSP", tenSP);
                        cmd.Parameters.AddWithValue("@GiaNhap", giaNhap);
                        cmd.Parameters.AddWithValue("@GiaXuat", giaXuat);
                        cmd.Parameters.AddWithValue("@KieuDang", kieuDang);
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                        cmd.Parameters.AddWithValue("@NgayNhap", ngayNhapFormatted);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@DaBan", daBan);
                        cmd.Parameters.AddWithValue("@ChatLieu", chatLieu);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("SẢN PHẨM ĐƯỢC CẬP NHẬT THÀNH CÔNG");
                            UpdateDataGridView();
                            ClearData();
                        }
                        else
                        {
                            MessageBox.Show("KHÔNG TÌM THẤY SẢN PHẨM CẬP NHẬT");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LỖI KHI CẬP NHẬT SẢN PHẨM: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật.");
            }
        }

        private void ClearData()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGianhap.Clear();
            txtGiaXuat.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            rdoCon.Checked = false;
            rdoHet.Checked = false;
            dtpNgayNhap.Value = DateTime.Now;
            txtSoluong.Clear();
            txtDaban.Clear();
            txtChatLieu.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
