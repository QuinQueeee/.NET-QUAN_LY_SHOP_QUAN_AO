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
    public partial class frm_TCHD : Form
    {
        DBConnect db = new DBConnect();
        DataTable dt_hd = new DataTable();
        public frm_TCHD()
        {
            InitializeComponent();
            db.connect();
            string sql = "select * from CHITIETHOADON";
            dt_hd = db.getDataTable(sql);

            DataColumn[] key = new DataColumn[2];
            key[0] = dt_hd.Columns[0];
            key[1] = dt_hd.Columns[1];
            dt_hd.PrimaryKey = key;
        }
        public void load_dgvHD()
        {
            dtgvHD.DataSource = dt_hd;
        }
        private void frm_TCHD_Load(object sender, EventArgs e)
        {
            load_dgvHD();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtMaHD.Text;
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                using (SqlConnection conn = db.getConnection())
                {
                    db.open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CHITIETHOADON WHERE MaHD LIKE @searchText", conn);
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt_search = new DataTable();
                    da.Fill(dt_search);
                    dtgvHD.DataSource = dt_search;
                }
            }
            else
                load_dgvHD();
        }
    }
}
