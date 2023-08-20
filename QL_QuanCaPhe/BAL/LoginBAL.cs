using QL_QuanCaPhe.DAL;
using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.BAL
{
    internal class LoginBAL
    {
        public static bool dangNhapBAL(Users users)
        {
            return LoginDAL.dangNhapDAL(users);
        }
    }
}
