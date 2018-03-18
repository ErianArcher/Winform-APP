using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace SCUT
{
    public class DBUtil
    {
        private static SqlConnection conn = null;
        private static object sycnObj = new Object();

        public static SqlConnection getConnection()
        {
            if (conn == null)
            {
                lock (sycnObj)
                {
                    if (conn == null)
                    {
                        conn = new SqlConnection("Data Source=.;Integrated Security = True;Database=SCUT2015");
                    }
                }
            }
            return conn;
        }

        public static int execCommand(string sql)
        {
            SqlConnection conn = getConnection();
            int succnum = 0;
            try
            {
                conn.Open();
                SqlCommand sqlCommand = conn.CreateCommand();
                sqlCommand.CommandText = sql;
                succnum = sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return succnum;
        }

        public static DataSet queryData(string sql)
        {
            SqlConnection conn = getConnection();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
    }
}
