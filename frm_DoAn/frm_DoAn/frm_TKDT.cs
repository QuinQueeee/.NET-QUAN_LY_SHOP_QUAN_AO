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
    public partial class frm_TKDT : Form
    {
        DBConnect db = new DBConnect();
        public frm_TKDT()
        {
            InitializeComponent();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpTungay.Value;
            DateTime toDate = dtpDenngay.Value;
            DataTable resultTable = ThongKeDoanhThu(fromDate, toDate);
            dgvThongKe.DataSource = resultTable;

            decimal tongTien = 0;
            foreach (DataRow row in resultTable.Rows)
            {
                tongTien += Convert.ToDecimal(row["ThanhTien"]);
            }

            lblTongTien.Text = "TỔNG TIỀN: " + tongTien.ToString("N0") + " VNĐ";
            lblThanhChu.Text = "THÀNH CHỮ: " + (tongTien != 0 ? NumberToWords(tongTien) : "Không đồng");
        }
        private string NumberToWords(decimal number)
        {
            try
            {
                string rs = "";
                decimal total = Math.Round(number, 0);
                string[] ch = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] rch = { "lẻ", "mốt", "", "", "", "lăm" };
                string[] u = { "", "mươi", "trăm", "nghìn", "", "", "triệu", "", "", "tỷ", "", "", "nghìn", "", "", "triệu" };
                string nstr = total.ToString();
                int[] n = new int[nstr.Length];
                int len = n.Length;
                for (int i = 0; i < len; i++)
                {
                    n[len - 1 - i] = Convert.ToInt32(nstr.Substring(i, 1));
                }
                for (int i = len - 1; i >= 0; i--)
                {
                    if (i % 3 == 2)// số 0 ở hàng trăm
                    {
                        if (n[i] == 0 && n[i - 1] == 0 && n[i - 2] == 0) continue;//nếu cả 3 số là 0 thì bỏ qua không đọc
                    }
                    else if (i % 3 == 1) // số ở hàng chục
                    {
                        if (n[i] == 0)
                        {
                            if (n[i - 1] == 0) { continue; }// nếu hàng chục và hàng đơn vị đều là 0 thì bỏ qua.
                            else
                            {
                                rs += " " + rch[n[i]]; continue;// hàng chục là 0 thì bỏ qua, đọc số hàng đơn vị
                            }
                        }
                        if (n[i] == 1)//nếu số hàng chục là 1 thì đọc là mười
                        {
                            rs += " mười"; continue;
                        }
                    }
                    else if (i != len - 1)// số ở hàng đơn vị (không phải là số đầu tiên)
                    {
                        if (n[i] == 0)// số hàng đơn vị là 0 thì chỉ đọc đơn vị
                        {
                            if (i + 2 <= len - 1 && n[i + 2] == 0 && n[i + 1] == 0) continue;
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 1)// nếu là 1 thì tùy vào số hàng chục mà đọc: 0,1: một / còn lại: mốt
                        {
                            rs += " " + ((n[i + 1] == 1 || n[i + 1] == 0) ? ch[n[i]] : rch[n[i]]);
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 5) // cách đọc số 5
                        {
                            if (n[i + 1] != 0) //nếu số hàng chục khác 0 thì đọc số 5 là lăm
                            {
                                rs += " " + rch[n[i]];// đọc số 
                                rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);//đọc đơn vị
                                continue;
                            }
                        }
                    }
                    rs += (rs == "" ? " " : ", ") + ch[n[i]];// đọc số
                    rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                }
                if (rs[rs.Length - 1] != ' ')
                    rs += " đồng";
                else
                    rs += "đồng";
                if (rs.Length > 2)
                {
                    string rs1 = rs.Substring(0, 2);
                    rs1 = rs1.ToUpper();
                    rs = rs.Substring(2);
                    rs = rs1 + rs;
                }
                return rs.Trim().Replace("lẻ,", "lẻ").Replace("mươi,", "mươi").Replace("trăm,", "trăm").Replace("mười,", "mười");
            }
            catch
            {
                return "";
            }
        }
        private DataTable ThongKeDoanhThu(DateTime fromDate, DateTime toDate)
        {
            DataTable resultTable = new DataTable();
            try
            {
                using (SqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string queryString = "SELECT HoaDon.MaHD as MaHD, HoaDon.NgayMua as NgayMua, " +
                      "SUM(ChiTietHoaDon.ThanhTien) as ThanhTien, " +
                      "NhanVien.MaNV as MaNV, " +
                      "KhachHang.MaKH as MaKH, " +
                      "HANGHOA.MaSP as MaSP, " +
                      "COUNT(HoaDon.MaHD) as SLuong " +
                      "FROM HoaDon " +
                      "INNER JOIN CHITIETHOADON ON HoaDon.MaHD = CHITIETHOADON.MaHD " +
                      "INNER JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV " +
                      "INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH " +
                      "INNER JOIN HANGHOA ON CHITIETHOADON.MaSP = HANGHOA.MaSP " +
                      "WHERE HoaDon.NgayMua >= @FromDate AND HoaDon.NgayMua <= @ToDate " +
                      "GROUP BY HoaDon.MaHD, HoaDon.NgayMua, NhanVien.MaNV, KhachHang.MaKH, HANGHOA.MaSP;";

                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@FromDate", fromDate.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@ToDate", toDate.ToString("yyyy-MM-dd"));

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(resultTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thống kê doanh thu: " + ex.Message);
            }

            return resultTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpTungay.Value;
            DateTime toDate = dtpDenngay.Value;
            DataTable resultTable = ThongKeDoanhThu(fromDate, toDate);
            frm_Report Report = new frm_Report(resultTable);

            //this.Hide(); // Ẩn formThongKe
            Report.Closed += (s, args) => this.Show(); // Đăng ký sự kiện Closed của formReport
            Report.Show();
        }
    }
}
