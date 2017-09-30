using System;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

/* ADDING REFERENCES TO: */ 
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DbUtils
/// </summary>
public class DbUtils
{

    public static DataTable SelectDataTable(string Sql)
    {
        DataTable dt = new DataTable();
        SqlConnection myConnnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MainDB"].ConnectionString);
        SqlDataAdapter da = new SqlDataAdapter(Sql, myConnnection);
        da.Fill(dt);
        return dt;
    }

    public static DataRow SelectDataRow(string Sql)
    {
        DataTable dt = SelectDataTable(Sql);
        if (dt.Rows.Count > 0)
        {
            return dt.Rows[0];
        }
        return null;
    }

    public static void ExNonQuery(string Sql)
    {
        SqlConnection myConnnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MainDB"].ConnectionString);
        SqlCommand cmd = new SqlCommand(Sql, myConnnection);
        myConnnection.Open();
        cmd.ExecuteNonQuery();
        myConnnection.Close();
    }
    public static object ExScalar(string Sql)
    {
        SqlConnection myConnnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MainDB"].ConnectionString);
        SqlCommand cmd = new SqlCommand(Sql, myConnnection);
        myConnnection.Open();
        object resultScalar= cmd.ExecuteScalar();
        myConnnection.Close();
        return resultScalar;
    }
}
