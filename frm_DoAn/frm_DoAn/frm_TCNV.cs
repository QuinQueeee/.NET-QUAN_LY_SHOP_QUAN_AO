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
    public partial class frm_TCNV : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_nv = new DataTable();
        public frm_TCNV()
        {
            InitializeComponent();
            db.connect();
            string sql = "select * from NHANVIEN";
            dt_nv = db.getDataTable(sql);

            DataColumn[] key = new DataColumn[1];
            key[0] = dt_nv.Columns[0];
            dt_nv.PrimaryKey = key;
        }
        public void load_dgvNV()
        {
            dtgvNV.DataSource = dt_nv;
        }
        private void frm_TCNV_Load(object sender, EventArgs e)
        {
            load_dgvNV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtMaTenNV.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                using (SqlConnection conn = db.getConnection())
                {
                    db.open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE MaNV LIKE @searchText OR TenNV LIKE @searchText", conn);
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt_search = new DataTable();
                    da.Fill(dt_search);
                    dtgvNV.DataSource = dt_search;
                }
            }
            else
                load_dgvNV();
        }
    }
}
