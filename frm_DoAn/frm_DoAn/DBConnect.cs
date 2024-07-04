using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace frm_DoAn
{
    public class DBConnect
    {
        SqlConnection conn;
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source = QUINQUE\QUIN; Initial Catalog = QL_SHOPTHOITRANG; User ID = sa; Password = 123");
        }
        public void connect()
        {
            string sql_connect = @"Data Source = QUINQUE\QUIN; Initial Catalog = QL_SHOPTHOITRANG; User ID = sa; Password = 123";
            conn = new SqlConnection(sql_connect);
        }
        public void open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public int getNonQuery(string sql)
        {
            SqlCommand cmd;
            open();
            cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();
            close();
            return kq;
        }
        public SqlDataReader getReader(string sql)
        {
            SqlCommand cmd;
            open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }
        public object getScalar(string sql)
        {
            SqlCommand cmd;
            open();
            cmd = new SqlCommand(sql, conn);
            int kq = (int)cmd.ExecuteScalar();
            close();
            return kq;
        }
        public DataTable getDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public int updateDatabase(string sql, DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dt);
            return (kq);
        }
        public object getScalar2(string sql)
        {
            SqlCommand cmd;
            open();
            cmd = new SqlCommand(sql, conn);

            object result = cmd.ExecuteScalar();

            // Close the connection before returning the result
            close();

            return result;
        }
    }
}
