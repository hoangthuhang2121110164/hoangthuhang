using QL_QuanCaPhe.DAL;
using QL_QuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.BAL
{
    internal class ProductBAL
    {
        public static void addProduct(Product product)
        {
            ProductDAL.addProduct(product); 
        }

        public static void updateProduct(Product product)
        {
            ProductDAL.updateProduct(product);
        }

        public static void deleteProduct(int id)
        {
            ProductDAL.deleteProduct(id);
        }
        public static void xuatBaoCao()
        {
            ProductDAL.xuatBaoCao();
        }
    }
}
