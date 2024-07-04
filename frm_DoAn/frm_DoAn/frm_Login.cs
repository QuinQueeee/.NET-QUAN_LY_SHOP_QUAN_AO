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
using System.Diagnostics;

namespace frm_DoAn
{
    public partial class frm_Login : Form
    {
        DBConnect db = new DBConnect();
        public frm_Login()
        {
            InitializeComponent();
            db.connect();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txbTaiKhoan.Text;
            string password = txbMatKhau.Text;
            //kiểm tra thông tin đăng nhập
            if(AuthenticateUser(username,password,out int roleId))
            {
                //kiểm tra vai trò của người đăng nhập 
                if (roleId == 1)
                {
                    //mở form làm việc của quản lí
                    MessageBox.Show("ĐĂNG NHẬP VỚI TƯ CÁCH QUẢN LÍ", "WELCOME");
                    frm_Main ql = new frm_Main();
                    ql.Show();
                }
                else if (roleId == 2)
                {
                    //mở form làm việc của nhân viên
                    MessageBox.Show("ĐĂNG NHẬP VỚI TƯ CÁCH NHÂN VIÊN", "WELCOME");
                    frm_MainNV nv = new frm_MainNV();
                    nv.Show();
                }
                this.Hide(); //ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!","Lỗi đăng nhập",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextBox)
                {
                    ((TextBox)childControl).Text = string.Empty;
                }
                else if (childControl.HasChildren)
                {
                    ClearTextBoxes(childControl);
                }
            }
        }

        private void ckbAnHien_CheckedChanged(object sender, EventArgs e)
        {
            txbMatKhau.PasswordChar = ckbAnHien.Checked ? '\0' : '*';
        }
        private bool AuthenticateUser(string username,string password,out int roleId)
        {
            roleId = 0; //khởi tạo giá trị khác 
            using (SqlConnection conn = db.getConnection())
            {
                try
                {
                    //kết nối với sql server
                    conn.Open();
                    string sql = "select RoleID from NHANVIEN where TenDangNhap=@Username and Password=@Password";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    SqlDataReader dr = cmd.ExecuteReader();
                    //kiểm tra có tồn tại người dùng trong csdl không
                    if(dr.Read())
                    {
                        roleId = (int)dr["RoleID"];
                        return true; //đăng nhập thành công
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false; //đăng nhập không thành công
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}
