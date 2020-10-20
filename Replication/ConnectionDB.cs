using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Replication
{
    class ConnectionDB
    {
        public SqlConnection GetConnection()
        {
            string s = "Data Source=192.168.22.134;Initial Catalog=test;User ID=huynh;Password=123456";
            SqlConnection conn = new SqlConnection(s);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection ok");
            }
            else
            {
                Console.WriteLine("Connection error");
            }
            return conn;
        }
    }
}
