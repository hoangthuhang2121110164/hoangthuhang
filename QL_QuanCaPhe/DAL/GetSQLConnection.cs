using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.DAL
{
    internal class GetSQLConnection
    {
        public static string str = "Data Source=DESKTOP-A8GF1M2\\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa";
        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(str);
                return connection;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
