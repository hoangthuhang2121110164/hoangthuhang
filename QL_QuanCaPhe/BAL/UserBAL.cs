using QL_QuanCaPhe.DAL;
using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.BAL
{
    internal class UserBAL
    {
        public static DataTable layDanhSach()
        {
            return UserDAL.layDanhSach();
        }
        public static void addUser(Users users)
        {
            UserDAL.addUser(users);
        }
        public static void updateUser(Users users)
        {
            UserDAL.updateUser(users);
        }
        public static void deleteUser(int id)
        {
            UserDAL.deleteUser(id);
        }
        public static void xuatBaoCao()
        {
            UserDAL.xuatBaoCao();
        }
    }
}
