using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseProject
{
    class command
    {

        public static string con = @"Data Source=DESKTOP-7NPJ8LK;Integrated Security=True";
        public SqlConnection sqlconnection;
        public SqlDataAdapter da = null;
        public DataTable dt;
        public SqlCommand cmd;
        public string sqlStr;
        public command(string sqlStr)
        {
            dt = new DataTable();
             this.sqlStr = sqlStr;
            sqlconnection = new SqlConnection(con);  
        }
        public DataTable datatable()
        {
            cmd = new SqlCommand(sqlStr, sqlconnection);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        
        }
    }
}
