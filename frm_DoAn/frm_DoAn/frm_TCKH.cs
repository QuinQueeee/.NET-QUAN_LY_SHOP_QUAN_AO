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
    public partial class frm_TCKH : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_kh = new DataTable();
        public frm_TCKH()
        {
            InitializeComponent();
            db.connect();
            string sql = "select * from KHACHHANG";
            dt_kh = db.getDataTable(sql);

            DataColumn[] key = new DataColumn[1];
            key[0] = dt_kh.Columns[0];
            dt_kh.PrimaryKey = key;
        }
        public void load_dgvKH()
        {
            dtgvKH.DataSource = dt_kh;
        }
        private void frm_TCKH_Load(object sender, EventArgs e)
        {
            load_dgvKH();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtMaTenKH.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                using (SqlConnection conn = db.getConnection())
                {
                    db.open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE MaKH LIKE @searchText OR TenKH LIKE @searchText", conn);
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt_search = new DataTable();
                    da.Fill(dt_search);
                    dtgvKH.DataSource = dt_search;
                }
            }
            else
                load_dgvKH();
        }
    }
}
