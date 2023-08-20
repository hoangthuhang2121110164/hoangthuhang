using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.DAL
{
    internal class LoginDAL
    {
            public static SqlConnection connection = GetSQLConnection.getConnection(); 
            public static bool dangNhapDAL(Users users)
            {
               connection.Open();
                SqlCommand command = new SqlCommand("select case when exists (select * from Users where username = N'" + users.username + "' and password = N'" + users.password + "') then 1 else 0 end", connection);
                int check = Convert.ToInt32(command.ExecuteScalar());
                if (check == 1) return true;
                else return false;
            }
        }
}
