using QL_QuanCaPhe.DAL;
using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.BAL
{
    internal class CategoryBAL
    {
        public static List<string> layDanhSachTen()
        {
            return CategoryDAL.layDanhSachTen();
        }
        public static int findIDByName(string name)
        {
            return CategoryDAL.findIDByName(name);
        }

        public static string findNameByID(int id)
        {
            return CategoryDAL.findNameByID(id);
        }

        public static void addCategory(Category category)
        {
            CategoryDAL.addCategory(category);
        }

        public static void updateCategory(Category category)
        {
            CategoryDAL.updateCategory(category);
        }

        public static void deleteCategory(int id)
        {
            CategoryDAL.deleteCategory(id);
        }
    }
}
