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
    public partial class frm_TCHH : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_hh = new DataTable();
        public frm_TCHH()
        {
            InitializeComponent();
            db.connect();
            string sql = "select * from HANGHOA";
            dt_hh = db.getDataTable(sql);

            DataColumn[] key = new DataColumn[1];
            key[0] = dt_hh.Columns[0];
            dt_hh.PrimaryKey = key;
        }
        public void load_dgvHH()
        {
            dtgvHH.DataSource = dt_hh;
        }
        private void frm_TCHH_Load(object sender, EventArgs e)
        {
            load_dgvHH();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtMaTenSP.Text))
            //{
            //    string sql = "select * from HANGHOA where MaSP LIKE '%" + txtMaTenSP.Text.Trim() + "%' or TenSP LIKE '%" + txtMaTenSP.Text.Trim() + "%'";
            //    DataTable dt_search = db.getDataTable(sql);
            //    dtgvHH.DataSource = dt_search;
            //}
            //else
            //    load_dgvHH();
            string searchText = txtMaTenSP.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                using (SqlConnection conn = db.getConnection())
                {
                    db.open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM HANGHOA WHERE MaSP LIKE @searchText OR TenSP LIKE @searchText", conn);
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt_search = new DataTable();
                    da.Fill(dt_search);
                    dtgvHH.DataSource = dt_search;
                }
            }
            else
                load_dgvHH();
        }
    }
}
