using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class Connection
    {
        
        public static SqlConnection sqlConn = new SqlConnection(@"Data Source=192.168.0.24,1433;Initial Catalog=esvit2020;User ID=esvit2021;Password=s3ss1st3m1;");
        public static   void OpenConnection()
        {
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
        }
    }
}
