using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.DTO
{
    internal class Product
    {
        public int id;
        public string name;
        public float price;
        public int quantity;
        public string description;
        public int categoryId;
        public byte[] img;
    }
}
