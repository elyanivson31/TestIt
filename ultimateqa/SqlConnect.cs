using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;


namespace ultimateqa
{
    static class SqlConnect
    {

        static string connectionString = ""; 
        //public SqlConnect()
        //{
        
        //}

     

        public  static DataTable SelectDataTable(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public static DataRow SelectDataRow(string sql)
        {
            DataTable dt = new DataTable();
            if(dt.Rows.Count>0)
            {
                return dt.Rows[0];
            }
            return null;
        }
    }
}

